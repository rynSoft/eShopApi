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

public class RouteInfoService : IRouteInfoService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IRepository<Domain.Entities.RouteInfo> _repository;
    
    public RouteInfoService(
           IAppDbContext appDbContext,
           IRepository<Domain.Entities.RouteInfo> repository, 
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        var entity = _appDbContext.RouteInfo.ToList();
        return new ResponseModel(entity);
    }
    public async Task<RouteInfoDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<RouteInfoDtoQ>(entity);
    }
    
    public async Task<IEnumerable<RouteInfoDtoQ>> GetAllAsyncProductId(int id)
    {
        var result  = _appDbContext.RouteInfo.Where(x=> x.ProductionId == id)
            .Select(x=> new RouteInfoDtoQ()
                {
                    Id = x.Id,
                    Explanation = x.Explanation,
                    UserId = x.UserId,          
                    State=x.State,
                    //userList = _appDbContext.RouteInfoUser.Where(t=>t.RouteInfoId==x.Id).Include(x => x.User).Select(t => new UserRouteInfoDto()
                    //{
                        
                    //    Id = t.User.Id,
                    //    Name = t.User.Ad,
                    //    SurName = t.User.Soyad,
                    //    UserRouteInfoId=t.Id,
                    //}).ToList(),
                    AdSoyad = x.User.Ad + " "+ x.User.Soyad,
                    KitHazirlamaState = _appDbContext.ProductionTimeProcess.Where(y=> y.ProductionId == id && y.ProductionProcess == ProductionProcess.KitProvision).OrderBy(y=>y.Id)
                                                                            .LastOrDefault().ProductionTimeStatus,
                    KitDogrulamaState  = _appDbContext.ProductionTimeProcess.Where(y=> y.ProductionId == id && y.ProductionProcess == ProductionProcess.KitVerification).OrderBy(y=>y.Id)
                        .LastOrDefault().ProductionTimeStatus,
                }
            ).OrderBy(x=> x.Id);
            
        return result;
    }
    public async Task<ResponseModel> Add(RouteInfoDtoC dto)
    {  
        var entity = _mapper.Map<RouteInfo>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(RouteInfoDtoC data)
    {
        var entity = _mapper.Map<Domain.Entities.RouteInfo>(data);
        return await _repository.UpdateAsync(entity);
    }
    public async Task<ResponseModel> UpdateState(RouteInfoDtoC data)
    {
        RouteInfo routeInfo = await _repository.GetSingleAsync(x => x.Id == data.Id);
        routeInfo.State = (bool)data.State;
        return await _repository.UpdateAsync(routeInfo);
    }

}