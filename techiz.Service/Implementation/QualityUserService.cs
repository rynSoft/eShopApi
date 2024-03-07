using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

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