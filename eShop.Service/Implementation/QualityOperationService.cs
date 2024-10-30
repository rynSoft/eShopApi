using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;
using Microsoft.IdentityModel.Tokens;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Enum;
using eShop.Domain.Settings;
using eShop.Service.Contract;
using eShop.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using eShop.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eShop.Domain.Entities;
using AutoMapper;
using eShop.Domain.Dtos;
using eShop.Persistence.Repositories;
using eShop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.Transactions;

namespace eShop.Service.Implementation
{
    public class QualityOperationService : IQualityOperationService
    {
        private readonly IRepository<QualityOperation> _repository;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IQualityUserService _qualityUserService;

        private IAppDbContext _appDbContext;
        public QualityOperationService(IRepository<QualityOperation> repository,
           IAppDbContext appDbContext,
             IHttpContextAccessor httpContextAccessor,
           IMapper mapper,
             IQualityUserService qualityUserService
            )
        {
            _repository = repository;
            _mapper = mapper;
            _qualityUserService = qualityUserService;
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ResponseModel> GetAll()
        {
            return new ResponseModel(_mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.OrderByDescending(x => x.Id).ToListAsync()));
        }
        public async Task<ResponseModel> GetById(int id)
        {
            return new ResponseModel(await _repository.GetAsync(id));
        }
        public async Task<ResponseModel> GetByLineId(int id)
        {
            return new ResponseModel(await _repository.GetWhereAsync(x => x.Id == id));
        }

        public async Task<ResponseModel> Add(QualityOperationDtoC dto)
        {
            var entity = _mapper.Map<QualityOperation>(dto);
            await _qualityUserService.Add(new QualityUserDtoC()
            {
                QualityProcess = QualityProcess.QualityConfirmation,
                Date = DateTimeOffset.Now,
                QualityId = Convert.ToInt32(dto.QualityId),
                Message = $" Kalite Operasyon Görevi Atandı . Kalite No: {dto.QualityId}",
                UserId = dto.UserApprovingId,
            });
       

            return await _repository.AddAsync(entity);
        }
        public async Task<ResponseModel> Update(QualityOperationDtoC dto)
        {
            var entity = _mapper.Map<QualityOperation>(dto);
            return new ResponseModel((await _repository.UpdateAsync(entity)));
        }

        public async Task<ResponseModel> Delete(int id)
        {
            QualityOperation quality = await _repository.GetSingleAsync(x => x.Id == id);
            return new ResponseModel( _repository.DeleteAsync(quality));
        }

        public async Task<ResponseModel> GetUserOperationList()
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
            var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;
            if (role == "SISTEMADMIN") 
            {            
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t=>t.Quality).Where(x=>x.Confirmation).OrderByDescending(x => x.Id).GroupBy(p => p.QualityId).Select(grp => grp.FirstOrDefault()).ToListAsync());
                return new ResponseModel(qualityOperation.OrderByDescending(x=>x.Id));
            }
            else
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).OrderByDescending(x => x.Id).Where(x=>x.UserLiableId == user&& x.Confirmation).GroupBy(p => p.QualityId).Select(grp => grp.FirstOrDefault()).ToListAsync());
                return new ResponseModel(qualityOperation.OrderByDescending(x => x.Id));
            }
        }

        public async Task<ResponseModel> GetApprowingUserList()
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
            var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;
            if (role == "SISTEMADMIN")
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.OrderByDescending(t => t.Id).Include(t => t.Quality).GroupBy(p => p.QualityId).Select(grp => grp.FirstOrDefault()).ToListAsync());
                
                return new ResponseModel(qualityOperation.OrderBy(x => x.Id));
            }
            else
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).OrderByDescending(x => x.Id).Where(x => x.UserApprovingId == user).GroupBy(p => p.QualityId).Select(grp => grp.FirstOrDefault()).ToListAsync());
                return new ResponseModel(qualityOperation.OrderBy(x => x.Id));
            }
        }

        public async Task<ResponseModel> GetUserAutherizationList()
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
            var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;
            if (role == "SISTEMADMIN")
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.OrderByDescending(t => t.Id).Include(t => t.Quality).Where(x=> x.EndOperation == true).GroupBy(p => p.QualityId).Select(grp => grp.FirstOrDefault()).ToListAsync());

                return new ResponseModel(qualityOperation.OrderByDescending(x => x.Id));
            }
            else
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).OrderByDescending(x => x.Id).Where(x => x.AuthorizedPersonId == user && x.EndOperation==true).GroupBy(p => p.QualityId).Select(grp => grp.FirstOrDefault()).ToListAsync());
                return new ResponseModel(qualityOperation.OrderByDescending(x => x.Id));
            }
        }
        
        public async Task<ResponseModel> GetUserApprowingDetail(int id)
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
            var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;
            if (role == "SISTEMADMIN")
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).Where(t=>t.QualityId==id ).OrderByDescending(x => x.Id).ToListAsync());
                return new ResponseModel(qualityOperation);
            }
            else
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).OrderByDescending(x => x.Id).Where(x => x.UserApprovingId == user && x.QualityId== id ).ToListAsync());
                return new ResponseModel(qualityOperation);
            }
        }

        public async Task<ResponseModel> GetUserApprowingDetailConfirmation(int id)
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
            var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;
            if (role == "SISTEMADMIN")
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).Where(t => t.QualityId == id && t.Confirmation==true).OrderByDescending(x => x.Id).ToListAsync());
                return new ResponseModel(qualityOperation);
            }
            else
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).OrderByDescending(x => x.Id ).Where(x => x.UserLiableId == user && x.QualityId == id && x.Confirmation == true).ToListAsync());
                return new ResponseModel(qualityOperation);
            }
        }

        public async Task<ResponseModel> GetUserAutherizationDetail(int id)
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
            var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;
            if (role == "SISTEMADMIN")
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).Where(t => t.QualityId == id &&  t.EndOperation == true).OrderByDescending(x => x.Id).ToListAsync());
                return new ResponseModel(qualityOperation);
            }
            else
            {
                var qualityOperation = _mapper.Map<List<QualityOperationDtoQ>>(await _appDbContext.QualityOperation.Include(t => t.Quality).OrderByDescending(x => x.Id).Where(x => x.AuthorizedPersonId == user && x.QualityId == id &&  x.EndOperation == true).ToListAsync());
                return new ResponseModel(qualityOperation);
            }
        }

        public async Task<ResponseModel> QualityOperationEndProcess(int id)
        {      
                var qualityOperation = _appDbContext.QualityOperation.Include(x=>x.Quality).Where(t => t.QualityId == id && (t.EndOperation == false || t.EndOperation == null)).FirstOrDefault();
                if(qualityOperation == null)
                {
                    return new ResponseModel("Sonlandırıldı",_appDbContext.Quality.Where(t => t.Id == id).FirstOrDefault().State);
               
                }
                 return new ResponseModel(true);
        }

        

        public async Task<ResponseModel> UpdateConfirmation(int id)
        {
            var data = _appDbContext.QualityOperation.Include(x=>x.Quality).Where(x => x.Id == id).FirstOrDefault();
            if(data == null)
            {
                return new ResponseModel("Başarısız",false);
            }
            else
            {
     

                using (TransactionScope ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    data.Confirmation = true;
                    data.EditDate = DateTimeOffset.Now;//Onay Tarihi Olarak Kullanıldı
                    _appDbContext.QualityOperation.Update(data);

                    await _appDbContext.SaveChangesAsync();

                    await _qualityUserService.Add(new QualityUserDtoC()
                    {
                        QualityProcess = QualityProcess.QualityOperation,
                        Date = DateTimeOffset.Now,
                        QualityId = Convert.ToInt32(data.QualityId),
                        Message = $" Kalite Operasyon Görevi Atandı . İş Emri No: {data.Quality.WorkOrderNumber}",
                        UserId = data.UserLiableId,
                    });
                    await _appDbContext.SaveChangesAsync();
                    ts.Complete();
                }



             

                return new ResponseModel("Başarılı",true);
            }

   
        }
        public async Task<ResponseModel> StartOperation(int id)
        {
            var data = _appDbContext.QualityOperation.Include(x => x.Quality).Where(x => x.Id == id).FirstOrDefault();
            if (data == null)
            {
                return new ResponseModel("Başarısız", false);
            }
            else
            {
                using (TransactionScope ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    data.StartOperation = true;
                    data.StartOperationDate = DateTimeOffset.Now;
                    _appDbContext.QualityOperation.Update(data);
                    await _appDbContext.SaveChangesAsync();
                    ts.Complete();
                }
                return new ResponseModel("Başarılı", true);
            }
        }
    }
}




