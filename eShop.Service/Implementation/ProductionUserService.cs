using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using eShop.Domain.Auth;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Enum;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class ProductionUserService : IProductionUserService
{
    private readonly IRepository<ProductionUser> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public ProductionUserService(IRepository<ProductionUser> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ProductionUser>>(await _appDbContext.ProductionUser.ToListAsync()));
    }
    public async Task<ResponseModel> GetAllAsyncProductId(int productionId)
    {
        return  new ResponseModel(_mapper.Map<List<ProductionUserDtoQ>>(await _appDbContext.ProductionUser
            .Where(i=> i.ProductionId==productionId).OrderBy(i => i.Date).ToListAsync()));
    }
    public async Task<ResponseModel> Add(ProductionUserDtoC dto)
    {  
        var entity = _mapper.Map<ProductionUser>(dto);
        return await _repository.AddAsync(entity);
    }


    public async Task<ResponseModel> Delete(int productionId,Guid userId , ProductionProcess ps)
    {
        ProductionUser productionUser = await _repository.GetSingleAsync(x => x.ProductionId == productionId && x.UserId == userId && x.ProductionProcess == ps);
        return new ResponseModel((await _repository.DeleteAsync(productionUser)));
    }




}