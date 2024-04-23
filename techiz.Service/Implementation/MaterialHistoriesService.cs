using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class MaterialHistoriesService : IMaterialHistoriesService
{
    private readonly IRepository<MaterialHistories> _repository;
    private readonly IMapper _mapper;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly IMaterialService _materialService;
    private readonly ILogger<MaterialHistoriesService> _logger;
    private readonly IAppDbContext _appDbContext;
    
    public MaterialHistoriesService(IRepository<MaterialHistories> repository, 
           IAppDbContext appDbContext,
           IHttpContextAccessor httpContextAccessor,
           ILogger<MaterialHistoriesService> logger,
           IMaterialService materialService,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
        _materialService = materialService; 
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<MaterialHistoriesDtoQ>>(await _appDbContext.MaterialHistories.OrderBy(x=> x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }

    public async Task<ResponseModel> GetAllAsyncMaterialHistories(int workProcessRouteId)
    {
        var data = _mapper.Map<List<MaterialHistoriesDtoQ>>(await _appDbContext.MaterialHistories
                   .Include(t => t.User)
                   .Include(y=> y.Material)
                   .Where(x => x.WorkProcessRouteId == workProcessRouteId).OrderByDescending(i => i.Id).Take(20).ToListAsync());
           
        return new ResponseModel(data);
    }

    public async Task<ResponseModel> GetByCodeHistories(int workProcessRouteId,string code)
    {
        if (!await _appDbContext.MaterialHistories.Where(x => x.WorkProcessRouteId == workProcessRouteId && x.Material.Code == code).AnyAsync())
        {
            return new ResponseModel() { Success = false, Message = $"Bu iş sürecinde bu {code}'lu ürün bulunamadı" };
        }else
        {
            return new ResponseModel() { Success = true,  Data = _appDbContext.MaterialHistories.Where(x => x.WorkProcessRouteId == workProcessRouteId && x.Material.Code == code).FirstOrDefaultAsync().Result?.MaterialId, Message = $"{code}'lu ürün bulundu" };
        }
    }


    public async Task<ResponseModel> Add(MaterialHistoriesDtoC dto)
    {  
       var entity = _mapper.Map<MaterialHistories>(dto);
       entity.UserId = _httpContextAccessor.HttpContext.GetCurrentUser();

        var resultId = _repository.AddAsync(entity).GetAwaiter().GetResult().Data;


        if ((int?)resultId > 0)
        {

            var result = await _materialService.Update(new MaterialDtoC { Id = dto.MaterialId, NextWPRId = dto.NextProcessRouteId});
            return new ResponseModel(result);
        }

        return new ResponseModel(Success : false);
    }

    public async Task<ResponseModel> ElapsedTimeCalculate(int workProcessRouteId)
    {
        MaterialHistories ps = new();
        if (ps != null)
        {
            var endStartTime = await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking()
                                                  .Where(x => x.WorkProcessRouteId == workProcessRouteId &&
                                                   ( x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Resume ||
                                                     x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Start))
                                                  .OrderByDescending(t => t.Id).FirstOrDefaultAsync();


            if (ps.BeginDate > endStartTime.CreateDate)
            {
                ps.ElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)ps.BeginDate).TotalSeconds;
            }
            else
            {
                ps.ElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)endStartTime.CreateDate).TotalSeconds;
            }

            ps.EndDate = DateTimeOffset.Now;

            await _repository.UpdateAsync(ps);
        }


        return new ResponseModel(null);
    }

 
}
