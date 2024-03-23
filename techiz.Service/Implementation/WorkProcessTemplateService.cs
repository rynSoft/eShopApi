using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Dtos.WorkProcessTemplate;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class WorkProcessTemplateService : IWorkProcessTemplateService
{
    private readonly IRepository<WorkProcessTemplate> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public WorkProcessTemplateService(IRepository<WorkProcessTemplate> repository,
           IAppDbContext appDbContext,
           IHttpContextAccessor httpContextAccessor,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }

    public async Task<ResponseModel> GetAll()
    {
       return new ResponseModel(_mapper.Map<List<WorkProcessTemplateDtoQ>>(await _appDbContext.WorkProcessTemplate.ToListAsync()));
    }

    public async Task<ResponseModel> GetAllListProductionId(int productionId)
    {
           var wpRoute = await _appDbContext.WorkProcessRoute
            .AsNoTracking()
            .Where(t=>  t.ProductionId == productionId)
            .Select(y => new WorkProcessRouteDtoQ()
            {
                Id = y.Id.ToString(),
                Name = y.Name,
                Content = y.WorkProcessTemplate.Name, //_appDbContext.WorkProcessTemplate.Where(z=> z.Id == y.WorkProcessTemplateId).FirstOrDefault().Name,
                Color = y.WorkProcessTemplate.Color,
                Icon = y.WorkProcessTemplate.Icon,
                RouteId = y.RouteId,
                VirtualName = y.VirtualName,
                ProductionId = y.ProductionId,
                WorkProcessTemplateId = y.WorkProcessTemplateId,
                UserList = _appDbContext.WorkProcessRouteUser.Where(t => t.WorkProcessRouteId == y.Id).Include(x => x.User).Select(t => new UserRouteInfoDto()
                {
                    WorkProcessRouteUserId = t.WorkProcessRouteId,
                    Id = t.User.Id,
                    Name = t.User.Ad,
                    SurName = t.User.Soyad,
                    WorkProcessRouteId = t.Id,
                }).ToList(),
                State = y.State,
                Active = y.State,
                Order = y.Order
            }).OrderBy(y=> y.Order).ToListAsync();

    WorkProcessTemplateInitialDtoQ st = new WorkProcessTemplateInitialDtoQ 
                                      { List1 = _mapper.Map<List<WorkProcessTemplateDtoQ>>(await _appDbContext.WorkProcessTemplate.Where(y => y.Active).ToListAsync()),
                                        List2 = _mapper.Map<List<WorkProcessRouteDtoQ>>(wpRoute)
        };
        return new ResponseModel(st);
    }

    public async Task<ResponseModel> GetNavListProductionId(int productionId)
    {
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
        var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;

        if (role == "SISTEMADMIN")
        {
            var wpRoute = await _appDbContext.WorkProcessRoute
                                             .Where(t => t.ProductionId == productionId)
                                             .Select(y => new
                                             {
                                                 Id = y.Id.ToString(),
                                                 Name = y.Name,
                                                 Order = y.Order,
                                                 WhichPage = y.WorkProcessTemplate.WhichPage
                                             }).OrderBy(t => t.Order).ToListAsync();


            return new ResponseModel(wpRoute);
        }
        else
        {
            var wpRoute = await _appDbContext.WorkProcessRouteUser
                                             .Where(t => t.WorkProcessRoute.ProductionId == productionId && t.UserId == user)
                         
                                             .Select(y => new
                                             {
                                                 Id = y.Id.ToString(),
                                                 Name = y.WorkProcessRoute.Name,
                                                 Order = y.WorkProcessRoute.Order,
                                                 WhichPage = y.WorkProcessRoute.WorkProcessTemplate.WhichPage
                                             }).OrderBy(t => t.Order).ToListAsync();

            return new ResponseModel(wpRoute);
        }


    }



    public async Task<ResponseModel> GetAllFilter()
    {
        return new ResponseModel(_mapper.Map<List<WorkProcessTemplateDtoQ>>(await _appDbContext.WorkProcessTemplate.Where(y=> y.Active).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> Add(WorkProcessTemplateDtoC dto)
    {  
        var entity = _mapper.Map<WorkProcessTemplate>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(WorkProcessTemplateDtoC dto)
    {
        var entity = _mapper.Map<WorkProcessTemplate>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        WorkProcessTemplate LineSingle = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(LineSingle)));
    }


}