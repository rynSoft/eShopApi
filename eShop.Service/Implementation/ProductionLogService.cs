using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class ProductionLogService : IProductionLogService
{
    private readonly IRepository<ProductionLog> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private IHttpContextAccessor _httpContextAccessor;
    public ProductionLogService(IRepository<ProductionLog> repository, 
           IAppDbContext appDbContext, IHttpContextAccessor httpContextAccessor,
           IMapper mapper)
    {
        _httpContextAccessor = httpContextAccessor;
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ProductionLog>>(await _appDbContext.ProductionLog.OrderByDescending(x=> x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetAllAsyncProductId(int productionId)
    {
        return  new ResponseModel(_mapper.Map<List<ProductionLogDtoQ>>(await _appDbContext.ProductionLog.Include(x=>x.User)
            .Where(i=> i.ProductionId==productionId).OrderByDescending(i => i.Id).ToListAsync()));
    }
    public async Task<ResponseModel> Add(ProductionLogDtoC dto)
    {
        dto.Date = DateTimeOffset.Now;
        dto.UserId =_httpContextAccessor.HttpContext.GetCurrentUser();
        var entity = _mapper.Map<ProductionLog>(dto);
        return await _repository.AddAsync(entity);
    }
   
  
}