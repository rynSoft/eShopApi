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

namespace eShop.Service.Implementation
{
    public class QualityInfoService : IQualityInfoService
    {
        private readonly IRepository<QualityInfo> _repository;

        private readonly IMapper _mapper;


        private IAppDbContext _appDbContext;
        public QualityInfoService(IRepository<QualityInfo> repository,
           IAppDbContext appDbContext,
           IMapper mapper

            )
        {
            _repository = repository;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        public async Task<ResponseModel> GetAll()
        {
            return new ResponseModel(_mapper.Map<List<QualityInfoDtoQ>>(await _appDbContext.QualityInfo.OrderByDescending(x => x.Id).ToListAsync()));
        }
        public async Task<ResponseModel> GetById(int id)
        {
            return new ResponseModel(await _repository.GetAsync(id));
        }
        public async Task<ResponseModel> GetByLineId(int id)
        {
            return new ResponseModel(await _repository.GetWhereAsync(x => x.Id == id));
        }


        public async Task<ResponseModel> Add(QualityInfoDtoC dto)
        {
            var entity = _mapper.Map<QualityInfo>(dto);
            return await _repository.AddAsync(entity);
        }
        public async Task<ResponseModel> Update(QualityInfoDtoC dto)
        {
            var entity = _mapper.Map<QualityInfo>(dto);
            return new ResponseModel((await _repository.UpdateAsync(entity)));
        }

        public async Task<ResponseModel> Delete(int id)
        {
            QualityInfo machina = await _repository.GetSingleAsync(x => x.Id == id);
            return new ResponseModel((await _repository.DeleteAsync(machina)));
        }

        public async Task<ResponseModel> GetQualityOperation(int id)
        {
            return new ResponseModel(_mapper.Map<List<QualityInfoDtoQ>>(await _appDbContext.QualityInfo.OrderByDescending(x => x.Id).Where(x=>x.QualityOperationId==id).ToListAsync()));
        }

        public async Task<ResponseModel> GetAllQuality(int id)
        {
            return new ResponseModel(_mapper.Map<List<QualityInfoDtoQ>>(await _appDbContext.QualityInfo.Include(t => t.Quality).OrderByDescending(x => x.Id).Where(x => x.QualityId == id).ToListAsync()));
        }
    }



}
