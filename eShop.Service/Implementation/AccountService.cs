using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;
using Microsoft.IdentityModel.Tokens;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Enum;
using techiz.Domain.Settings;
using techiz.Service.Contract;
using techiz.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using techiz.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Entities;
using AutoMapper;
using techiz.Domain.Dtos;
using Microsoft.AspNetCore.Http;

namespace techiz.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        private readonly SignInManager<User> _signInManager;
        private readonly IEmailService _emailService;
        private readonly JWTSettings _jwtSettings;
        private readonly IDateTimeService _dateTimeService;
        private readonly IMapper _mapper;
        private readonly IFeatureManager _featureManager;
        private IHttpContextAccessor _httpContextAccessor;
        private IAppDbContext _appDbContext;
        public AccountService(UserManager<User> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IOptions<JWTSettings> jwtSettings,
            IDateTimeService dateTimeService,
            SignInManager<User> signInManager,
            IAppDbContext appDbContext,
            IMapper mapper,
            IEmailService emailService,
            IFeatureManager featureManager, IHttpContextAccessor httpContextAccessor
            )
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtSettings = jwtSettings.Value;
            _dateTimeService = dateTimeService;
            _signInManager = signInManager;
            _appDbContext = appDbContext;
            _emailService = emailService;
            _mapper = mapper;
            _featureManager = featureManager;

        }

        public async Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new ApiException($"No Accounts Registered with {request.Email}.");
            }
            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                throw new ApiException($"Invalid Credentials for '{request.Email}'.");
            }

            JwtSecurityToken jwtSecurityToken = await GenerateJWToken(user);

            AuthenticationResponse response = new AuthenticationResponse();
            response.Id = user.Id;
            response.JWToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            response.Email = user.Email;
            response.UserName = user.UserName;
            response.UserNameSurname = $"{user.Ad} {user.Soyad}";
            response.Image = user.Image;
            var rolesList = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
            response.Roles = rolesList.ToList();
            var rol = _appDbContext.Role.Where(x => x.Name == rolesList[0]).FirstOrDefault();
            var userClaims = await _appDbContext.RoleClaims.Where(x => x.RoleId == rol.Id).Select(x => x.ClaimValue).ToListAsync();
            response.Permissions = userClaims;

            var refreshToken = GenerateRefreshToken(ipAddress);
            response.RefreshToken = refreshToken.Token;

            _appDbContext.RefreshToken.RemoveRange(_appDbContext.RefreshToken.Where(c => c.UserId == user.Id));
            await _appDbContext.SaveChangesAsync();
            _appDbContext.RefreshToken.Add(new RefreshToken
            {
                UserId = user.Id,
                Expires = refreshToken.Expires,
                Token = response.JWToken
            });
            await _appDbContext.SaveChangesAsync();


            return new Response<AuthenticationResponse>(response, $"Authenticated {user.UserName}");
        }


        public async Task<Response<Boolean>> TokenSessionControl()
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            return new Response<bool>(user == null ? false : true);
        }

        public async Task<ResponseModel> RegisterAsync(RegisterRequest request, string origin)
        {
            var userWithSameUserName = await _userManager.FindByEmailAsync(request.Email);
            if (userWithSameUserName != null)
            {
                throw new ApiException($"'{request.Email}' zaten Kullanılmakta");
            }

            var user = new User
            {
                Email = request.Email,
                UserName = request.UserName,
                Ad = request.Ad,
                Soyad = request.Soyad,
                Image = request.Image,
                PhoneNumber = request.TelefonGSM

            };

            var userWithSameEmail = await _userManager.FindByNameAsync(request.Email);
            if (userWithSameEmail == null)
            {
                var result = await _userManager.CreateAsync(user, request.Password);
                if (result.Succeeded)
                {
                    if (!await _userManager.IsInRoleAsync(user, request.RoleId))
                    {
                        var getRoleName = await _roleManager.FindByIdAsync(request.RoleId);
                        var resultUserRoles = await _userManager.AddToRoleAsync(user, getRoleName.NormalizedName);


                        var role = await _roleManager.FindByNameAsync(getRoleName.NormalizedName);
                        var permissionroles = _appDbContext.RoleClaims.ToList().FindAll(x => x.RoleId == role.Id);
                        foreach (IdentityRoleClaim<Guid> uvm in permissionroles)
                        {
                            _appDbContext.UserClaims.Add(new IdentityUserClaim<Guid>
                            {
                                UserId = user.Id,
                                ClaimValue = uvm.ClaimValue,
                                ClaimType = "permission"
                            });

                        }
                        await _appDbContext.SaveChangesAsync();
                    }

                    await _appDbContext.SaveChangesAsync();

                    return new ResponseModel() { Data = true, Message = "Kayıt Başarılı" };

                }
                else
                {
                    return new ResponseModel() { Data = false, Message = result.Errors.ToList()[0].Description };

                }
            }
            else
            {
                return new ResponseModel() { Data = false, Message = $"PbikId {request.Email} Zaten Kayıtlı" };

            }
        }


        private async Task<JwtSecurityToken> GenerateJWToken(User user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim("roles", roles[i]));
            }

            string ipAddress = IpHelper.GetIpAddress();
            //string ipAddress = "";

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                //new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id.ToString()),
                new Claim("ip", ipAddress)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        private string RandomTokenString()
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            var randomBytes = new byte[40];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            // convert random bytes to hex string
            return BitConverter.ToString(randomBytes).Replace("-", "");
        }

        private async Task<string> SendVerificationEmail(User user, string origin)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var route = "api/account/confirm-email/";
            var _enpointUri = new Uri(string.Concat($"{origin}/", route));
            var verificationUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "userId", user.Id.ToString());
            verificationUri = QueryHelpers.AddQueryString(verificationUri, "code", code);
            //Email Service Call Here
            return verificationUri;
        }

        public async Task<Response<string>> ConfirmEmailAsync(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return new Response<string>(user.Id.ToString(), message: $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.");
            }
            else
            {
                throw new ApiException($"An error occured while confirming {user.Email}.");
            }
        }

        private RefreshToken GenerateRefreshToken(string ipAddress)
        {
            return new RefreshToken
            {
                Token = RandomTokenString(),
                Expires = DateTime.UtcNow.AddDays(1),
                Created = DateTime.UtcNow,
                CreatedByIp = ipAddress
            };
        }

        public async Task ForgotPassword(ForgotPasswordRequest model, string origin)
        {
            var account = await _userManager.FindByEmailAsync(model.Email);

            // always return ok response to prevent email enumeration
            if (account == null) return;

            var code = await _userManager.GeneratePasswordResetTokenAsync(account);
            var route = "api/account/reset-password/";
            var _enpointUri = new Uri(string.Concat($"{origin}/", route));
            var emailRequest = new MailRequest()
            {
                Body = $"You reset token is - {code}",
                ToEmail = model.Email,
                Subject = "Reset Password",
            };
            await _emailService.SendEmailAsync(emailRequest);
        }

        public async Task<Response<string>> ResetPassword(ResetPasswordRequest model)
        {
            var account = await _userManager.FindByEmailAsync(model.Email);
            if (account == null) throw new ApiException($"No Accounts Registered with {model.Email}.");
            var result = await _userManager.ResetPasswordAsync(account, model.Token, model.Password);
            if (result.Succeeded)
            {
                return new Response<string>(model.Email, message: $"Password Resetted.");
            }
            else
            {
                throw new ApiException($"Error occured while reseting the password.");
            }
        }

        public async Task<ResponseModel> GetAllAsync()
        {
            // var usersDto = _mapper.Map<List<UserInformationDto>>(_userManager.Users.Include(x=> x.UserRole).ToListAsync());
            var usersDto = await _userManager.Users
                .Include(y => y.UserRole)
                .Select(x => new UserInformationDto()
                {
                    Id = x.Id,
                    Name = x.Ad,
                    SurName = x.Soyad,
                    Email = x.Email,
                    Phone = x.PhoneNumber,
                    UserName = x.UserName,
                    Image = x.Image,
                    Status = x.IsActive ? "active" : "inactive",
                    Role = _appDbContext.Role.Where(b => b.Id == x.UserRole.FirstOrDefault().RoleId).FirstOrDefault().NormalizedName
                })
                .ToListAsync();

            return new ResponseModel(usersDto);
        }

        public async Task<ResponseModel> GetAllTaskAsync(Guid Id)
        {
            // var usersDto = _mapper.Map<List<UserInformationDto>>(_userManager.Users.Include(x=> x.UserRole).ToListAsync());
            var usersDto = await _appDbContext.ProductionUser.Where(x => x.UserId == Id && x.OpenState == false)
                .Select(x => new
                {
                    Id = x.Id,
                    Message = x.Message,
                    ProductionProcess = x.ProductionProcess,
                    Dates = x.Date,
                    ProductionId = x.ProductionId
                })
                .ToListAsync();

            return new ResponseModel(usersDto);
        }
        public async Task<ResponseModel> GetAllTaskQualityAsync(Guid Id)
        {
            // var usersDto = _mapper.Map<List<UserInformationDto>>(_userManager.Users.Include(x=> x.UserRole).ToListAsync());
            var usersDto = await _appDbContext.QualityUser.Where(x => x.UserId == Id && x.OpenState == false)
                .Select(x => new
                {
                    Id = x.Id,
                    Message = x.Message,
                    QualityProcess = x.QualityProcess,
                    Dates = x.Date,
                    QualityId = x.QualityId
                })
                .ToListAsync();

            return new ResponseModel(null);
        }
        public async Task<ResponseModel> UpdateTaskAsync(int Id)
        {
            var productionUser = _appDbContext.ProductionUser.Where(x => x.Id == Id).FirstOrDefault();
            productionUser.OpenState = true;

            _appDbContext.ProductionUser.Update(productionUser);
            await _appDbContext.SaveChangesAsync();

            return new ResponseModel(new ResponseModel(Success: true));
        }
        public async Task<ResponseModel> UpdateTaskQualityAsync(int Id)
        {
            var productionUser = _appDbContext.QualityUser.Where(x => x.Id == Id).FirstOrDefault();
            productionUser.OpenState = true;
            _appDbContext.QualityUser.Update(productionUser);
            await _appDbContext.SaveChangesAsync();
            return new ResponseModel(new ResponseModel(Success: true));
        }
        public async Task<ResponseModel> Delete(Guid id)
        {
            var user = await _appDbContext.User.FindAsync(id);
            if (user == null)
            {
                return new ResponseModel() { Data = true, Message = "Başarılı" };
            }

            _appDbContext.User.Remove(user);
            await _appDbContext.SaveChangesAsync();

            return new ResponseModel() { Data = false, Message = "Hata" };
        }


        public async Task<ResponseModel> PutUser(UserInformationDto? dto)
        {
            var user = await _appDbContext.User.Include(y => y.UserRole).FirstOrDefaultAsync(x => x.Id == dto.Id);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, dto.Password);
            if (result.Succeeded)
            {
                user.Ad = dto.Name;
                user.Soyad = dto.SurName;
                user.Email = dto.Email;
                user.TelefonGSM = dto.Phone;
                user.PhoneNumber = dto.Phone;
                user.UserName = dto.UserName;
                user.Image = dto.Image;
                try
                {


                    await _appDbContext.SaveChangesAsync();



                    //if (user.UserRole != null && user.UserRole.FirstOrDefault().RoleId != dto.RoleId)
                    //{

                    //    var userRole = await _appDbContext.UserRole.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == user.Id);

                    //    if (userRole != null)
                    //    {
                    //        _appDbContext.UserRole.Remove(userRole);
                    //        await _appDbContext.SaveChangesAsync();
                    //    }
                    //    _appDbContext.UserRole.Add(new IdentityUserRole<Guid>() { RoleId = (Guid)dto.RoleId, UserId = dto.Id });
                    //    await _appDbContext.SaveChangesAsync();

                    //    // Claimler Değişmesi Gerekecek Sonraki sürecte bakalım 
                    //}
                    return new ResponseModel() { Data = true, Message = "Başarılı" };
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new ResponseModel() { Data = false, Message = result.Errors.ToList()[0].Description };
                }


            }
            else
            {
                return new ResponseModel() { Data = false, Message = result.Errors.ToList()[0].Description };

            }

        }
    }

}
