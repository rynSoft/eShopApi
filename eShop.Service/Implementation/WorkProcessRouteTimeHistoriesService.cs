using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Enum;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class WorkProcessRouteTimeHistoriesService : IWorkProcessRouteTimeHistoriesService
{
    private readonly IRepository<WorkProcessRouteTimeHistories> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IProductionLogService _productionLogService;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<WorkProcessRouteTimeHistories> _logger;

    public WorkProcessRouteTimeHistoriesService(IRepository<WorkProcessRouteTimeHistories> repository, 
           IAppDbContext appDbContext,
           IMapper mapper,
           IHttpContextAccessor httpContextAccessor,
           ILogger<WorkProcessRouteTimeHistories> logger,
           IProductionLogService productionLogService)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
        _productionLogService = productionLogService;
    }
    
    public async Task<IEnumerable<WorkProcessRouteTimeHistoriesDtoQ>> GetAllAsyncRouteId(int id)
    {
        var process = await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking().Where(x => x.WorkProcessRouteId == id)
            .Select(x => new WorkProcessRouteTimeHistoriesDtoQ()
                {
                    //UserAd =  _appDbContext.User.Where(y=> y.Id == x.UserId).FirstOrDefault().Ad,
                    //UserSoyad =  _appDbContext.User.Where(y=> y.Id == x.UserId).FirstOrDefault().Soyad,
                    Date = x.StartDate,
                    Message=x.Definition,
                    ElapsedTime = x.ElapsedTime,
                    RestCause = x.RestCause.Name,
                    WorkProcessRouteTimeStatus = EnumHelper<WorkProcessRouteTimeStatus>.GetDisplayValue(x.WorkProcessRouteTimeStatus),
                }
            ).OrderByDescending(x=> x.Date).ToListAsync();
      
        return  process;
    }
    
    public async Task<ResponseModel> Start(WorkProcessRouteTimeHistoriesDtoC dto)
    {
        _logger.LogWarning($"WorkProcessRouteTime | Start : Start W");
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        //await AddWorkProcessRouteLog(dto);

        dto.WorkProcessRouteTimeStatus = WorkProcessRouteTimeStatus.Start;
        dto.UserId = (Guid)user;
        var entity = _mapper.Map<WorkProcessRouteTimeHistories>(dto);
        _logger.LogWarning($"WorkProcessRouteTime | Start : End");
        return await _repository.AddAsync(entity);
    }
    
    public async Task<ResponseModel> Pause(WorkProcessRouteTimeHistoriesDtoC dto)
    {
        _logger.LogWarning($"WorkProcessRouteTime | Pause : Start");
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        var lastData = await _appDbContext.WorkProcessRouteTimeHistories
                                                            .AsNoTracking()
                                                            .Where(x=> x.WorkProcessRouteId == dto.WorkProcessRouteId )
                                                            .OrderBy(x => x.Id).LastOrDefaultAsync();
       
        if (lastData?.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Resume)
        {       

            lastData.EndDate = DateTimeOffset.UtcNow;
           
            await _repository.UpdateAsync(lastData);
        }
        
        if (dto.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Pause )
        {
            lastData.ElapsedTime = DateTimeOffset.Now - lastData.StartDate;
            await _repository.UpdateAsync(lastData);
        }

        
        dto.WorkProcessRouteTimeStatus = WorkProcessRouteTimeStatus.Pause;
        //dto.ElapsedTime = DateTimeOffset.Now - lastData.StartDate;
        dto.UserId = user == null ? dto.UserId : (Guid)user;
        var entity = _mapper.Map<WorkProcessRouteTimeHistories>(dto);
        _logger.LogWarning($"WorkProcessRouteTime | Pause : End");
        return await _repository.AddAsync(entity);
    }
    
    public async Task<ResponseModel> Resume(WorkProcessRouteTimeHistoriesDtoC dto)
    {
        _logger.LogWarning($"WorkProcessRouteTime | Resume : Start");
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        var lastData = await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking()
                                                            .Where(x=> x.WorkProcessRouteId == dto.WorkProcessRouteId
                                                                && !(x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Resume || x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Start))
                                                            .OrderBy(x => x.Id).LastOrDefaultAsync();

        if (lastData?.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Pause)
        {
            lastData.EndDate = DateTime.Now;
            await _repository.UpdateAsync(lastData);
        }

        if (dto.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Resume)
        {
            if (_appDbContext.RestCause.Where(x => x.Id == lastData.RestCauseId).AsNoTracking().FirstOrDefault().Hanging)
                lastData.ElapsedTime = TimeSpan.Zero;
            else
               lastData.ElapsedTime = DateTimeOffset.Now - lastData.StartDate;
            await _repository.UpdateAsync(lastData);
        }
     
        dto.WorkProcessRouteTimeStatus = WorkProcessRouteTimeStatus.Resume;
        dto.UserId = (Guid)user;
        var entity = _mapper.Map<WorkProcessRouteTimeHistories>(dto);
        _logger.LogWarning($"WorkProcessRouteTime | Resume : End");
        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> Stop(WorkProcessRouteTimeHistoriesDtoC dto)
    {
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        await AddWorkProcessRouteLog(dto);

        var lastData = await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking()
                                                            .Where(x => x.WorkProcessRouteId == dto.WorkProcessRouteId)
                                                            .OrderBy(x => x.Id).LastOrDefaultAsync();

        lastData.EndDate = DateTimeOffset.Now;
        await _appDbContext.SaveChangesAsync();



        dto.ElapsedTime = DateTimeOffset.Now - lastData.StartDate;
        dto.WorkProcessRouteTimeStatus = WorkProcessRouteTimeStatus.Stop;
        dto.UserId = (Guid)user;
        var entity = _mapper.Map<WorkProcessRouteTimeHistories>(dto);
        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> StopVirtual(WorkProcessRouteTimeHistoriesDtoC dto)
    {
        await AddWorkProcessRouteLog(dto);
        return new ResponseModel();
    }
    
    public async Task<ResponseModel> Update(WorkProcessRouteTimeHistories dto)
    {
        var entity =  _mapper.Map<WorkProcessRouteTimeHistories>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    private async Task<bool> AddWorkProcessRouteLog(WorkProcessRouteTimeHistoriesDtoC dto)
    {
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        await _productionLogService.Add(new ProductionLogDtoC()
        {
            Date = DateTimeOffset.Now,
            ProductionId = (int)dto.ProductionId,
            Message = dto.Definition,
            UserId = (Guid)user,
        });

        return false;
    }
}

 