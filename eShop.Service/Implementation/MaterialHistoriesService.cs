using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
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

    public async Task<ResponseModel> GetAllMaterialHistories(int productionId,int workProcessRouteId)
    {
        var leftOuterJoin =
             from d in _appDbContext.Material.Where(y=> y.ProductionId == productionId)
             join e in _appDbContext.MaterialHistories.Where(z=> z.WorkProcessRouteId == workProcessRouteId)
             on d.Id equals e.MaterialId into eGroup
             from e in eGroup.DefaultIfEmpty()

             join m in _appDbContext.WareHouse
             on d.WareHouseId equals m.Id into wh
             from m in wh



             select new
             {
                 Id = d.Id,
                 Code = d.Code,
                 Name = d.Name,
                 DepoAdi = m.Name,
                 Quantity = d.Quantity,
                 Unit = d.Unit,
                 DecreaseQuantity = d.DecreaseQuantity,
                 IsRead = e != null ? true : false,
                 MaterailReadState = e.MaterailReadState == null ? 0 : e.MaterailReadState,
                 MaterialUsableState = e.MaterialUsableState == null ? 0 : 1,
                 WareHouseCode = m.Code


             };

        return new ResponseModel( leftOuterJoin);
    }

    public async Task<ResponseModel> GetByCodeHistories(int workProcessRouteId,string code)
    {
        if (!await _appDbContext.MaterialHistories.Where(x => x.WorkProcessRouteId == workProcessRouteId && x.Material.Code == code).AnyAsync())
        {
            return new ResponseModel() { Success = false, Message = $"Bu iş sürecinde bu {code}'lu hammadde bulunamadı" };
        }else
        {
            return new ResponseModel() { Success = true,  Data = _appDbContext.MaterialHistories.Where(x => x.WorkProcessRouteId == workProcessRouteId && x.Material.Code == code).FirstOrDefaultAsync().Result?.MaterialId, Message = $"{code}'lu ürün bulundu" };
        }
    }


    public async Task<ResponseModel> Add(MaterialHistoriesDtoC dto)
    {  
        var entity = _mapper.Map<MaterialHistories>(dto);
        entity.UserId = _httpContextAccessor.HttpContext.GetCurrentUser();
        entity.Date = DateTimeOffset.UtcNow;
        var resultId = _repository.AddAsync(entity).GetAwaiter().GetResult().Data;


        if ((int?)resultId > 0)
        {

            var result = await _materialService.Update(new MaterialDtoC { Id = dto.MaterialId, ProductionId = dto.ProductionId, NextWPRId = dto.NextProcessRouteId});
            return new ResponseModel(result);
        }

        return new ResponseModel(Success : false);
    }

    public async Task<ResponseModel> ElapsedTimeCalculate(int workProcessRouteId)
    {
        //MaterialHistories ps = new();
        //if (ps != null)
        //{
        //    var endStartTime = await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking()
        //                                          .Where(x => x.WorkProcessRouteId == workProcessRouteId &&
        //                                           ( x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Resume ||
        //                                             x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Start))
        //                                          .OrderByDescending(t => t.Id).FirstOrDefaultAsync();


        //    if (ps.BeginDate > endStartTime.CreateDate)
        //    {
        //        ps.ElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)ps.BeginDate).TotalSeconds;
        //    }
        //    else
        //    {
        //        ps.ElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)endStartTime.CreateDate).TotalSeconds;
        //    }

        //    ps.EndDate = DateTimeOffset.Now;

        //    await _repository.UpdateAsync(ps);
        //}


        return new ResponseModel(null);
    }

 
}
