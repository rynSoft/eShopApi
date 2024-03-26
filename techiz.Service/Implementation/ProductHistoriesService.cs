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
    private readonly ILogger<ProductService> _logger;
    private readonly IAppDbContext _appDbContext;
    
    public ProductHistoriesService(IRepository<ProductHistories> repository, 
           IAppDbContext appDbContext,
           IHttpContextAccessor httpContextAccessor,
           ILogger<ProductService> logger,
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
        return  new  ResponseModel(_mapper.Map<List<ProductHistoriesDtoQ>>(await _appDbContext.ProductionOperations.OrderBy(x=> x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }

    public async Task<ResponseModel> GetAllAsyncProductHistories(int workProcessRouteId, int productionId, int isProductPage)
    {
        var lst = await _appDbContext.ProductHistories.Where(t => t.WorkProcessRouteId == workProcessRouteId).Select(y => y.ProductId).ToListAsync();
        var product = await _appDbContext.Product.Where(d => d.ProductionId == productionId && !lst.Contains(d.Id)).Select(y => new { Id = y.Id, QrCode = y.Qrcode }).Take(20).ToListAsync();
        var productHistories = await _appDbContext.ProductHistories.Include(t => t.User).OrderByDescending(i => i.EndDate).Take(20).ToListAsync();

        if (isProductPage == 1)
        {
            var data = new
            {
                notRead = product,

                read = _mapper.Map<List<ProductHistoriesDtoQ>>(await _appDbContext.ProductHistories
                  .Include(t => t.User)
                  .Where(x => x.BeginDate != null && x.WorkProcessRouteId == workProcessRouteId).OrderByDescending(i => i.EndDate).Take(20).ToListAsync())
            };
            return new ResponseModel(data);
        }

        if (isProductPage == 0)
        {
            var data = new
            {
                notRead = productHistories,

                read = _mapper.Map<List<ProductHistoriesDtoQ>>(await _appDbContext.ProductHistories
                  .Include(t => t.User)
                  .Where(x => x.BeginDate != null && x.WorkProcessRouteId == workProcessRouteId).OrderByDescending(i => i.EndDate).Take(20).ToListAsync())
            };
            return new ResponseModel(data);
        }

        return new ResponseModel(null);
    }

    public async Task<ResponseModel> GetByQrCode(string code, int workProcessRouteId, int productionId, int isProductPage)
    {
        if (!await _appDbContext.Product.Where(x => x.ProductionId == productionId && x.Qrcode == code.Trim()).AnyAsync())
            return new ResponseModel() { Success = false, Message = $"Bu iş emrinde {code}'lu ürün bulunamadı" };
        else
        {
            workProcessRouteId = _appDbContext.Product.Where(x => x.ProductionId == productionId && x.Qrcode == code.Trim()).FirstOrDefaultAsync().Result.NextWPRId;

            if (!await _appDbContext.ProductHistories.Where(x => x.Product.ProductionId == productionId  && x.WorkProcessRouteId == workProcessRouteId && x.Product.Qrcode == code.Trim() && x.ElapsedTime == null).AnyAsync())
            {
                await Add(new ProductHistoriesDtoC() { BeginDate = DateTimeOffset.UtcNow, WorkProcessRouteId = workProcessRouteId, UserId = _httpContextAccessor.HttpContext.GetCurrentUser() });
                return new ResponseModel() { Success = true };
            }
              
            else
                return new ResponseModel() { Success = false, Message = $"Bu iş emrinde {code}'lu ürün daha önce bu rotaya eklenmiş" };
        }
    }
    
    private async Task<ResponseModel> Add(ProductHistoriesDtoC dto)
    {  
       var entity = _mapper.Map<ProductHistories>(dto);
        return await _repository.AddAsync(entity);

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

    public async Task<ResponseModel> Update(ProductHistoriesDtoC dto)
    {
        //var kontrol = await _appDbContext.ProductionProcessManual.Where(x => x.ProductionId == dto.ProductionId && x.LabelingBeginDate != null  &&
        //                                                                     x.LabelingElapsedTime == null).FirstOrDefaultAsync();
        //var entity = await _appDbContext.ProductionProcessManual.Where(x => x.Id == dto.Id).FirstOrDefaultAsync();
        //if (kontrol is not null)
        //{
        //    await ElapsedTimeCalculate( dto.work, kontrol);
        //}
        //if (entity is not null)
        //{
        //    if (dto.QrCode.Trim() != "Finish24061994")
        //    {
        //        entity.LabelingUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
        //        entity.LabelingBeginDate = DateTimeOffset.Now;
        //        return new ResponseModel((await _repository.UpdateAsync(entity)));
        //    }
        //    else
        //    {
        //        entity.LabelingUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
        //        entity.LabelingBeginDate = DateTimeOffset.Now;
        //        return new ResponseModel((await _repository.UpdateAsync(kontrol)));
        //    }
        //}
        //else
        //{
        return new ResponseModel(Success: false);
        // }

    }
}
