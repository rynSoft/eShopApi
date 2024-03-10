using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

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
    
    public async Task<IEnumerable<WorkProcessRouteDtoQ>> GetAllAsyncProductId(int id)
    {
        var result  = _appDbContext.WorkProcessRoute.Where(x=> x.ProductionId == id)
            .Select(x=> new WorkProcessRouteDtoQ()
                {
                    Id = x.Id,
                    State=x.State,
                    Name = x.Name,
                    VirtualName = x.VirtualName,
                    ProductionId = x.ProductionId,
                    WorkProcessTemplateId = x.WorkProcessTemplateId,
                    WorkProcessTemplate = x.WorkProcessTemplate,
                    Order = x.Order,
                    UserList = _appDbContext.WorkProcessRouteUser.Where(t=>t.WorkProcessRouteId == x.Id).Include(x => x.User).Select(t => new UserRouteInfoDto()
                    {
                        Id = t.User.Id,
                        Name = t.User.Ad,
                        SurName = t.User.Soyad,
                        UserRouteInfoId=t.Id,
                    }).ToList(),
                }
            ).OrderBy(x=> x.Id);
            
        return result;
    }

    public async Task<ResponseModel> AddAll(List<WorkProcessRouteDtoC> dto)
    {
        try
        {
            foreach (var item in dto)
            {
                var entity = _mapper.Map<WorkProcessRoute>(item);
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
        var entity = _mapper.Map<Domain.Entities.WorkProcessRoute>(data);
        return await _repository.UpdateAsync(entity);
    }
    public async Task<ResponseModel> UpdateState(WorkProcessRouteDtoC data)
    {
        WorkProcessRoute routeInfo = await _repository.GetSingleAsync(x => x.Id == data.Id);
        routeInfo.State = (bool)data.State;
        return await _repository.UpdateAsync(routeInfo);
    }

}