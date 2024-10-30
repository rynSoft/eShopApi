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
using eShop.Domain;
using System.Transactions;
using Microsoft.AspNetCore.Http;

namespace eShop.Service.Implementation
{
    public class QualityService : IQualityService
    {
        private readonly IRepository<Quality> _repository;

        private readonly IMapper _mapper;
        private IHttpContextAccessor _httpContextAccessor;
        private readonly IQualityUserService _qualityUserService;
        private IAppDbContext _appDbContext;
        public QualityService(IRepository<Quality> repository,
           IAppDbContext appDbContext, IHttpContextAccessor httpContextAccessor,
           IMapper mapper,
                  IQualityUserService qualityUserService
            )
        {
            _qualityUserService = qualityUserService;
            _repository = repository;
            _mapper = mapper;
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ResponseModel> GetAll()
        {


            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
            var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;
            if (role == "SISTEMADMIN")
            {
                return new ResponseModel(_mapper.Map<List<QualityDtoQ>>(await _appDbContext.Quality.OrderByDescending(x => x.Id).ToListAsync()));
            }
            else
            {
                return new ResponseModel(_mapper.Map<List<QualityDtoQ>>(await _appDbContext.Quality.OrderByDescending(x => x.Id).Where(z=>z.EditorId==user).ToListAsync()));
            }


         
        }
        public async Task<ResponseModel> GetById(int id)
        {
            return new ResponseModel(await _repository.GetAsync(id));
        }
        public async Task<ResponseModel> GetByLineId(int id)
        {
            return new ResponseModel(await _repository.GetWhereAsync(x => x.Id == id));
        }

        public async Task<ResponseModel> Add(QualityDtoC dto)
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var entity = _mapper.Map<Quality>(dto);
            entity.EditorId = user;
            return await _repository.AddAsync(entity);
        }
        public async Task<ResponseModel> Update(QualityDtoC dto)
        {
            var user = _httpContextAccessor.HttpContext.GetCurrentUser();
            var entity = _mapper.Map<Quality>(dto);
            entity.EditorId = user;
            return new ResponseModel((await _repository.UpdateAsync(entity)));
        }

        public async Task<ResponseModel> UpdateState(int id)
        {
            Quality quality = await _repository.GetSingleAsync(x => x.Id == id);
            quality.State = true;
            return new ResponseModel((await _repository.UpdateAsync(quality)));
        }

        public async Task<ResponseModel> Delete(int id)
        {
            Quality quality = await _repository.GetSingleAsync(x => x.Id == id);
            return new ResponseModel((await _repository.DeleteAsync(quality)));
        }


        public async Task<ResponseModel> QualityAndOperationAdd(QualityAndOperationDtoC dto)
        {

            using (TransactionScope ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var user = _httpContextAccessor.HttpContext.GetCurrentUser();
                Quality quality = _mapper.Map<Quality>(dto.quality);
                quality.EditorId = user;
               var qualityResponse = await _repository.AddAsync(quality);
                List<QualityOperation> operationList = new List<QualityOperation>();
                foreach (var operation in dto.operationList)
                {
                    operation.QualityId = Convert.ToInt32(qualityResponse.Data.ToString());
                    var operationConvert = _mapper.Map<QualityOperation>(operation);
              
                    await _appDbContext.QualityOperation.AddAsync(operationConvert);
                    await _appDbContext.SaveChangesAsync();
                    await _qualityUserService.Add(new QualityUserDtoC()
                    {
                        QualityProcess = QualityProcess.QualityConfirmation,
                        Date = DateTimeOffset.Now,
                        QualityId=Convert.ToInt32(qualityResponse.Data.ToString()),
                        Message = $" Kalite Onay Görevi Atandı . İş Emri No: {dto.quality.WorkOrderNumber}",
                        UserId = operationConvert.UserApprovingId
                    });
                    await _appDbContext.SaveChangesAsync();
                }
            
                  
     
              

                ts.Complete();
            }

      
            return new ResponseModel("Başarılı", true);
        }



        public async Task<IEnumerable<SetupVerificationDto>> GetAllAsyncProductId(int id)
        {

            var result = _appDbContext.SetupVerification
                .Where(x => x.ProductionId == id)
                .Select(x => new SetupVerificationDto()
                {
                    Id = x.Id,

                    ProductionId = x.ProductionId,

                }
            ).OrderBy(x => x.Id);

            return result;
        }

        public async Task<QualityAndOperationDtoQ> GetQualityDetail(int id)
        {

            var result = _appDbContext.Quality.Where(x => x.Id == id).Select(x => new QualityAndOperationDtoQ()
            {
                quality = x,
                operationList = _appDbContext.QualityOperation.Where(x => x.QualityId == id).ToList()
            }
        ).FirstOrDefault();
            return result;


        }


    }
    }
