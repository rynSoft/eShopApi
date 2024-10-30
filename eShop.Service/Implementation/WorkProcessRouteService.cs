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

public class WorkProcessRouteService : IWorkProcessRouteService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IRepository<Domain.Entities.WorkProcessRoute> _repository;
    
    public WorkProcessRouteService(
           IAppDbContext appDbContext,
           IRepository<Domain.Entities.WorkProcessRoute> repository, 
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        var entity = _appDbContext.WorkProcessRoute.ToList();
        return new ResponseModel(entity);
    }
    public async Task<WorkProcessRouteDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<WorkProcessRouteDtoQ>(entity);
    }

    public async Task<ResponseModel> GetOrderNextId(int productionId, int workProcessRouteId , int order)
    {
        var IsProductPage =  _appDbContext.WorkProcessRoute.Where(x => x.ProductionId == productionId && x.Id != workProcessRouteId && x.Order == (order -1) &&
                                                                     x.WorkProcessTemplate.WPTState != WorkProcessTemplateState.Template)
                                                           .Select(y => new { IsProductPage = y.WorkProcessTemplate.WhichPage == "Product" ? 1 : 0, Order = y.Order })
                                                           .FirstOrDefaultAsync()?.Result?.IsProductPage;

        var nextWorkProcess = await _appDbContext.WorkProcessRoute.Where(x => x.ProductionId == productionId &&  x.Id != workProcessRouteId && x.Order > order &&
                                                                            x.WorkProcessTemplate.WPTState != WorkProcessTemplateState.Template)
                                                                  .Select(y=> new { Id = y.Id, Order = y.Order , IsProductPage = IsProductPage } )    
                                                                  .OrderBy(z=> z.Order).FirstOrDefaultAsync();



        return new ResponseModel(nextWorkProcess);
    }

    public async Task<IEnumerable<WorkProcessRouteDtoQ>> GetAllAsyncProductId(int id)
    {
        var result  = _appDbContext.WorkProcessRoute.Where(x=> x.ProductionId == id)
            .Select(x=> new WorkProcessRouteDtoQ()
                {
                    Id = x.Id.ToString(),
                    State=x.State,
                    Name = x.Name,
                    VirtualName = x.VirtualName,
                    ProductionId = x.ProductionId,
                WorkProcessTemplateId = x.WorkProcessTemplateId,
                //WorkProcessTemplateDtoQ = x.WorkProcessTemplate,
                Order = x.Order,
                    UserList = _appDbContext.WorkProcessRouteUser.Where(t=>t.WorkProcessRouteId == x.Id).Include(x => x.User).Select(t => new UserRouteInfoDto()
                    {
                        Id = t.User.Id,
                        Name = t.User.Ad,
                        SurName = t.User.Soyad,
                        WorkProcessRouteId = t.Id,
                    }).ToList(),
                }
            ).OrderBy(x=> x.Order);
            
        return result;
    }

    public async Task<IEnumerable<WorkProcessRouteDashboardDtoQ>> GetAllProductIdDashboard(int id)
    {
        var result = _appDbContext.WorkProcessRoute.Where(x => x.ProductionId == id)
            .Select(x => new WorkProcessRouteDashboardDtoQ()
            {
                Progress = x.WorkProcessTemplate.WPTState == WorkProcessTemplateState.Product && _appDbContext.Product.Where(t => t.ProductionId == id).Count() >0 ? 
                (( _appDbContext.Product.Where(t => t.ProductionId == id).Count() * 100 ) /
                _appDbContext.Production.Where(d=> d.Id == id).FirstOrDefault().Quantity  ) 
                
                :
                 x.WorkProcessTemplate.WPTState == WorkProcessTemplateState.ProductHistories && _appDbContext.ProductHistories.Where(t => t.Product.ProductionId == id && t.WorkProcessRouteId == x.Id).Count()>0  ?
                    ((_appDbContext.ProductHistories.Where(t => t.Product.ProductionId == id && t.WorkProcessRouteId == x.Id).Count() * 100) / 
                    _appDbContext.Production.Where(d => d.Id == id).FirstOrDefault().Quantity) 
                    :
                (_appDbContext.MaterialHistories.Where(t => t.Material.ProductionId == id && t.WorkProcessRouteId == x.Id).Count()>0 ? 
                (_appDbContext.MaterialHistories.Where(t => t.Material.ProductionId == id && t.WorkProcessRouteId == x.Id).Count() * 100 ) /_appDbContext.Material.Where(d => d.ProductionId == id).Count() : 0) 
              
                ,
                ProgressColor = x.ProgressColor,
                SubTitle = x.Name,
                Title = x.Name,
                Img = x.Img,
                Order=x.Order 
           }).ToList().OrderBy(x => x.Order);

        return result;
    }


    public async Task<ResponseModel> AddorUpdateAll(List<WorkProcessRouteDtoC> dto)
    {
        try
        {
            foreach (var item in dto)
            {
                var entity = _mapper.Map<WorkProcessRoute>(item);
                if (_appDbContext.WorkProcessRoute.Any(y=> y.Id == entity.Id))
                    await _repository.UpdateAsync(entity);
                else
                    await _repository.AddAsync(entity);
            }
        }
        catch (Exception)
        {
            return new ResponseModel(Success: false);
        }
        return new ResponseModel(Success: true);
    }           


    public async Task<ResponseModel> Add(WorkProcessRouteDtoC dto)
    {  
        var entity = _mapper.Map<WorkProcessRoute>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(WorkProcessRouteDtoC data)
    {
        var entity = _mapper.Map<WorkProcessRoute>(data);
        return await _repository.UpdateAsync(entity);
    }
  
    public async Task<ResponseModel> UpdateState(WorkProcessRouteDtoC data)
    {
        WorkProcessRoute routeInfo = await _repository.GetSingleAsync(x => x.Id == Convert.ToInt32(data.Id));
        routeInfo.State = (bool)data.State;
        return await _repository.UpdateAsync(routeInfo);
    }

    public async Task<ResponseModel> Delete(int id)
    {
        WorkProcessRoute workProcessRouteSingle = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(workProcessRouteSingle)));
    }


}