using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class QualityUserService : IQualityUserService
{
    private readonly IRepository<QualityUser> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public QualityUserService(IRepository<QualityUser> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ProductionUser>>(await _appDbContext.QualityUser.ToListAsync()));
    }
    public async Task<ResponseModel> GetAllAsyncProductId(int qualityId)
    {
        return  new ResponseModel(_mapper.Map<List<QualityUserDtoC>>(await _appDbContext.QualityUser
            .Where(i=> i.QualityId== qualityId).OrderBy(i => i.Date).ToListAsync()));
    }
    public async Task<ResponseModel> Add(QualityUserDtoC dto)
    {  
        var entity = _mapper.Map<QualityUser>(dto);
        return await _repository.AddAsync(entity);
    }
   
  
}