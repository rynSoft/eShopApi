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

public class ProductHistoriesService : IProductHistoriesService
{
    private readonly IRepository<ProductHistories> _repository;
    private readonly IMapper _mapper;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly IProductService _productService;
    private readonly IMaterialDecreaseHistoryService _materialDecreaseHistoryService;
    
    private readonly ILogger<ProductHistoriesService> _logger;
    private readonly IAppDbContext _appDbContext;
    
    public ProductHistoriesService(IRepository<ProductHistories> repository, 
           IAppDbContext appDbContext,
           IHttpContextAccessor httpContextAccessor,
           IMaterialDecreaseHistoryService materialDecreaseHistoryService,
    ILogger<ProductHistoriesService> logger,
           IProductService productService,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
        _materialDecreaseHistoryService = materialDecreaseHistoryService;
        _productService = productService; 
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ProductHistoriesDtoQ>>(await _appDbContext.ProductionOperations.AsNoTracking().OrderBy(x=> x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }

    public async Task<ResponseModel> GetAllAsyncProductHistories(int workProcessRouteId)
    {
        var data = _mapper.Map<List<ProductHistoriesDtoQ>>(await _appDbContext.ProductHistories.AsNoTracking()
                   .Include(t => t.User)
                   .Include(y=> y.Product)
                   .Where(x => x.WorkProcessRouteId == workProcessRouteId).OrderByDescending(i => i.Id).Take(20).ToListAsync());
           
        return new ResponseModel(data);
    }

    public async Task<ResponseModel> GetByQrCodeHistories(int workProcessRouteId,string code)
    {
        if (!await _appDbContext.ProductHistories.AsNoTracking().Where(x => x.WorkProcessRouteId == workProcessRouteId && x.Product.Qrcode == code).AnyAsync())
        {
            return new ResponseModel() { Success = false, Message = $"Bu iş sürecinde bu {code}'lu ürün bulunamadı" };
        }else
        {
            return new ResponseModel() { Success = true,  Data = _appDbContext.ProductHistories.Where(x => x.WorkProcessRouteId == workProcessRouteId && x.Product.Qrcode == code).FirstOrDefaultAsync().Result?.ProductId, Message = $"{code}'lu ürün bulundu" };
        }
    }


    public async Task<ResponseModel> Add(ProductHistoriesDtoC dto)
    {
        _logger.LogWarning($"ProductHistories | Add : Start Control in Db");
        if (!await _appDbContext.ProductHistories.AnyAsync(x => x.WorkProcessRouteId == dto.WorkProcessRouteId && x.ProductId == dto.ProductId))
        {
            _logger.LogWarning($"ProductHistories | Add : Start Control not in Db");
            var entity = _mapper.Map<ProductHistories>(dto);
            _logger.LogWarning($"ProductHistories | Add : Dto Mapping ");
            entity.UserId = _httpContextAccessor.HttpContext.GetCurrentUser();
            _logger.LogWarning($"ProductHistories | Add : Get CurrentUser ");

            List<MaterialDecreaseHistoryDtoC> jsonData = dto.Metarialds;

            var resultId = _repository.AddAsync(entity).GetAwaiter().GetResult().Data;
            _logger.LogWarning($"ProductHistories | Add : Add Completed ");

            if (jsonData != null)
                foreach (var item in jsonData)
                {
                    await _materialDecreaseHistoryService.Add(new MaterialDecreaseHistoryDtoC { ProductHistoriesId = (int)resultId, MaterialId = item.MaterialId, Quantity = item.Quantity, WorkProcessRouteId = dto.WorkProcessRouteId });
                }
            _logger.LogWarning($"ProductHistories | Add : MaterialDecreaseHistory Completed ");

            if ((int?)resultId > 0 && dto.NextProcessRouteId > 0)
            {

                var result = await _productService.Update(new ProductDtoC { Id = dto.ProductId, NextWPRId = dto.NextProcessRouteId, ProductionId = dto.ProductionId, Qrcode = dto.ProductQrCode, Order = (int)dto.Order });

            }
            _logger.LogWarning($"ProductHistories | Add : Product Update Completed ");
            return new ResponseModel { Success = true, Message = "Kayıt Başarılı." };
        }
        else
        {
            return new ResponseModel { Success = false, Message = "Ürün Daha Önce Kaydetilmiş." };
        }
   
        }

    public async Task<ResponseModel> ElapsedTimeCalculate(int workProcessRouteId)
    {
        ProductHistories ps = new();
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
