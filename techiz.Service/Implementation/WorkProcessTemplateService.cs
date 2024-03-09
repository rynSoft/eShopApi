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