using System;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using System.Threading.Tasks;
using eShop.Domain.Dtos;

namespace eShop.Service.Contract
{
    public interface IAccountService
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
        Task<ResponseModel> RegisterAsync(RegisterRequest request, string origin);
        Task<Response<Boolean>> TokenSessionControl();  
        Task<Response<string>> ConfirmEmailAsync(string userId, string code);
        Task ForgotPassword(ForgotPasswordRequest model, string origin);
        Task<Response<string>> ResetPassword(ResetPasswordRequest model);
        Task<ResponseModel> GetAllAsync();
        Task<ResponseModel> GetAllTaskAsync(Guid Id);
        Task<ResponseModel> GetAllTaskQualityAsync(Guid Id);
        Task<ResponseModel> UpdateTaskAsync(int Id);
        Task<ResponseModel> UpdateTaskQualityAsync(int Id);
        Task<ResponseModel> Delete(Guid id);
        Task<ResponseModel> PutUser(UserInformationDto? dto);


    }
}
