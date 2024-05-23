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

public class WorkProcessRouteTemplateService : IWorkProcessRouteTemplateService
{
    private readonly IRepository<WorkProcessRouteTemplate> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public WorkProcessRouteTemplateService(IRepository<WorkProcessRouteTemplate> repository,
           IAppDbContext appDbContext,
           IMapper mapper,
           IHttpContextAccessor httpContextAccessor)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<ResponseModel> GetAll()
    {
       return new ResponseModel(_mapper.Map<List<WorkProcessRouteTemplateDtoQ>>(await _appDbContext.WorkProcessRouteTemplate.ToListAsync()));
    }

    public async Task<ResponseModel> GetAllFilter()
    {
        return new ResponseModel(_mapper.Map<List<WorkProcessRouteTemplateDtoQ>>(await _appDbContext.WorkProcessRouteTemplate.Where(y=> y.Active).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> Add(WorkProcessRouteTemplateDtoC dto)
    {  
        var entity = _mapper.Map<WorkProcessRouteTemplate>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(WorkProcessRouteTemplateDtoC dto)
    {
        var entity = _mapper.Map<WorkProcessRouteTemplate>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        WorkProcessRouteTemplate WorkProcessRouteTemplateSingle = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(WorkProcessRouteTemplateSingle)));
    }


}