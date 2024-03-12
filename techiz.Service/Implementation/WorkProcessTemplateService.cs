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

    public WorkProcessTemplateService(IRepository<WorkProcessTemplate> repository,
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }

    public async Task<ResponseModel> GetAll()
    {
       return new ResponseModel(_mapper.Map<List<WorkProcessTemplateDtoQ>>(await _appDbContext.WorkProcessTemplate.ToListAsync()));
    }

    public async Task<ResponseModel> GetAllListProductionId(int productionId)
    {
           var wpRoute = await _appDbContext.WorkProcessRoute
            .Where(t=> t.Active && t.ProductionId == productionId)
            .Select(y => new WorkProcessRouteDtoC()
            {
                Id = y.Id.ToString(),
                Name = y.Name,
                Content = _appDbContext.WorkProcessTemplate.Where(z=> z.Id == y.WorkProcessTemplateId).FirstOrDefault().Name,
                RouteId = y.RouteId,
                VirtualName = y.VirtualName,
                ProductionId = y.ProductionId,
                WorkProcessTemplateId = y.WorkProcessTemplateId,
                State = y.State,
                Active = y.State,
                Order = y.Order
            }).ToListAsync();


    WorkProcessTemplateInitialDtoQ st = new WorkProcessTemplateInitialDtoQ 
                                      { List1 = _mapper.Map<List<WorkProcessTemplateDtoQ>>(await _appDbContext.WorkProcessTemplate.Where(y => y.Active).ToListAsync()),
                                        List2 = _mapper.Map<List<WorkProcessRouteDtoC>>(wpRoute)
        };
        return new ResponseModel(st);
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