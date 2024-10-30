using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Enum;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class RouteInfoUserService : IRouteInfoUserService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IProductionUserService _productionUserService;
    private readonly IRepository<Domain.Entities.RouteInfoUser> _repository;

    public RouteInfoUserService(
           IAppDbContext appDbContext,
           IRepository<Domain.Entities.RouteInfoUser> repository,
           IMapper mapper,
           IProductionUserService productionUserService)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
        _productionUserService = productionUserService;
    }

    public async Task<ResponseModel> GetAll()
    {
        var entity = _appDbContext.RouteInfo.ToList();
        return new ResponseModel(entity);
    }
    public async Task<RouteInfoUserDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<RouteInfoUserDtoQ>(entity);
    }
    
    public async Task<IEnumerable<RouteInfoUserDtoQ>> GetAllAsyncProductId(int id)
    {
        var result  = _appDbContext.RouteInfoUser.Where(x=> x.RouteInfoId == id)
            .Select(x=> new RouteInfoUserDtoQ()
                {
                    Id = x.Id,             
                    UserId = x.UserId,
                }
            ).OrderBy(x=> x.Id);
            
        return result;
        // IEnumerable<RouteInfoDtoQ> routeKitInfo = _mapper.Map<IEnumerable<Domain.Entities.RouteInfo>,IEnumerable<RouteInfoDtoQ>>
        //     (await _repository.GetWhereAsync(x=>x.ProductionId == id)); 
        // return routeKitInfo;
    }
    public async Task<ResponseModel> Add(RouteInfoUserDtoC dto)
    {
        if (dto.RouteInfoId is not null)
        {
            var routeInfo = await _appDbContext.RouteInfo.Include(y => y.Production).Where(z => z.Id == dto.RouteInfoId).FirstOrDefaultAsync();

            await _productionUserService.Add(new ProductionUserDtoC()
            {
                ProductionProcess = routeInfo.ProductionProcess,
                Date = DateTimeOffset.Now,
                ProductionId = routeInfo.ProductionId,
                Message = $"Yeni Görev Atandı . Üretim Numarası {routeInfo.Production.OrderNo}",
                UserId = dto.UserId
            });

            var entity = _mapper.Map<RouteInfoUser>(dto);
            return await _repository.AddAsync(entity);
        }
        return new ResponseModel();
    }
    public async Task<ResponseModel> Update(RouteInfoUserDtoC data)
    {
        var entity = _mapper.Map<RouteInfoUser>(data);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<ResponseModel> Delete(int id)
    {
        RouteInfoUser routeInfo = await _appDbContext.RouteInfoUser.Include(y=> y.RouteInfo).Where(x => x.Id == id).FirstOrDefaultAsync();

        var st = await _productionUserService.Delete(routeInfo.RouteInfo.ProductionId,(Guid)routeInfo.UserId,routeInfo.RouteInfo.ProductionProcess);


       return new ResponseModel((await _repository.DeleteAsync(routeInfo)));
    }
}