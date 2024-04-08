using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using MailKit.Search;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;
namespace techiz.Service.Implementation;

public class WorkProcessRouteMaterialService : IWorkProcessRouteMaterialService
{
    private readonly IMapper _mapper;
    private IAppDbContext _appDbContext;

    private readonly IRepository<Domain.Entities.WorkProcessRouteMaterial> _repository;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<WorkProcessRouteMaterialService> _logger;

    public WorkProcessRouteMaterialService(
        IAppDbContext appDbContext,
           IRepository<Domain.Entities.WorkProcessRouteMaterial> repository,
           IHttpContextAccessor httpContextAccessor,
           ILogger<WorkProcessRouteMaterialService> logger,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }

    public async Task<ResponseModel> GetAll()
    {
        var material = await _appDbContext.WorkProcessRouteMaterial.OrderByDescending(x => x.Id).ToListAsync();
        return new ResponseModel(material);
    }

    public async Task<ResponseModel> GetAllWorkProcessRouteMaterialId(int productionId)
    {
        var production = await _appDbContext.WorkProcessRouteMaterial.Where(x => x.WorkProcessRouteId == productionId)
            .Select(x => new WorkProcessRouteMaterialDtoQ()
            {

                Id = x.Id,

            })
            .OrderBy(x => x.Id).ToListAsync();
        return new ResponseModel(production);
    }

    public async Task<WorkProcessRouteMaterialDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x => x.Id == id);
        return _mapper.Map<WorkProcessRouteMaterialDtoQ>(entity);
    }
    public async Task<ResponseModel> Add(WorkProcessRouteMaterialDtoC dto)
    {
            var entity = _mapper.Map<WorkProcessRouteMaterial>(dto);
            _logger.LogWarning($"Material | Add : End Succes");

            return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> Update(WorkProcessRouteMaterialDtoC dto)
    {
        var entity = _mapper.Map<WorkProcessRouteMaterial>(dto);

        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        WorkProcessRouteMaterial material = _appDbContext.WorkProcessRouteMaterial.Where(x => x.Id == id).FirstOrDefault();

        _appDbContext.WorkProcessRouteMaterial.Remove(material);
        await _appDbContext.SaveChangesAsync();

        return new ResponseModel { Success = false, Message = "Uretim Emri Bulunamadi" };
    }



}
      
      
