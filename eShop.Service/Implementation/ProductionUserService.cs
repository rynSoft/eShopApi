using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

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