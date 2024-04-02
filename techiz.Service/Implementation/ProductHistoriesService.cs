using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
    private readonly ILogger<ProductService> _logger;
    private readonly IAppDbContext _appDbContext;
    
    public ProductHistoriesService(IRepository<ProductHistories> repository, 
           IAppDbContext appDbContext,
           IHttpContextAccessor httpContextAccessor,
           ILogger<ProductService> logger,
           IProductService productService,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
        _productService = productService; 
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ProductHistoriesDtoQ>>(await _appDbContext.ProductionOperations.OrderBy(x=> x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }

    public async Task<ResponseModel> GetAllAsyncProductHistories(int workProcessRouteId)
    {
        var data = _mapper.Map<List<ProductHistoriesDtoQ>>(await _appDbContext.ProductHistories
                   .Include(t => t.User)
                   .Include(y=> y.Product)
                   .Where(x => x.WorkProcessRouteId == workProcessRouteId).OrderByDescending(i => i.Id).Take(20).ToListAsync());
           
        return new ResponseModel(data);
    }

    public async Task<ResponseModel> GetByQrCodeHistories(int workProcessRouteId,string code)
    {
        if (!await _appDbContext.ProductHistories.Where(x => x.WorkProcessRouteId == workProcessRouteId && x.Product.Qrcode == code).AnyAsync())
        {
            return new ResponseModel() { Success = false, Message = $"Bu iş sürecinde bu {code}'lu ürün bulunamadı" };
        }else
        {
            return new ResponseModel() { Success = true,  Data = _appDbContext.ProductHistories.Where(x => x.WorkProcessRouteId == workProcessRouteId && x.Product.Qrcode == code).FirstOrDefaultAsync().Result?.ProductId, Message = $"{code}'lu ürün bulundu" };
        }
    }


    public async Task<ResponseModel> Add(ProductHistoriesDtoC dto)
    {  
       var entity = _mapper.Map<ProductHistories>(dto);
        entity.UserId = _httpContextAccessor.HttpContext.GetCurrentUser();

        if (_repository.AddAsync(entity).GetAwaiter().GetResult().Success)
        {
            var result = await _productService.Update(new ProductDtoC { Id = dto.ProductId, NextWPRId = dto.NextProcessRouteId, ProductionId = dto.ProductionId ,Qrcode = dto.ProductQrCode, Order = (int)dto.Order});
            return new ResponseModel(result);
        }
          
        return new ResponseModel(Success : false);
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
