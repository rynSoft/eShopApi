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
using Newtonsoft.Json;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;
using static techiz.Domain.Utilities.Permissions;

namespace techiz.Service.Implementation;

public class ProductionService : IProductionService
{
    private readonly IMapper _mapper;
    private IAppDbContext _appDbContext;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly IRepository<Domain.Entities.Production> _repository;

    public ProductionService(
        IAppDbContext appDbContext,
           IRepository<Domain.Entities.Production> repository,
           IHttpContextAccessor httpContextAccessor,
            
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        var production = await _appDbContext.Production.OrderByDescending(x=> x.Id).ToListAsync();
        return new ResponseModel(production);
    }
    
    public async Task<ResponseModel> GetProductionProcessAll(ProductionProcess ps)
    {
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        var roleId = _appDbContext.UserRole.Where(x => x.UserId == user).FirstOrDefault().RoleId;
        var role = _appDbContext.Role.Where(x => x.Id == roleId).FirstOrDefault().NormalizedName;
        
        if (role == "SISTEMADMIN")
        {
            var production = await _appDbContext.Production.Where(x => x.Id == x.RouteInfo.Where(y=> y.ProductionProcess == ps)
                                                           .FirstOrDefault().ProductionId)
                                                           .OrderByDescending(x=> x.Id)
                                                           .ToListAsync();
            return new ResponseModel(production);
        }
        else
        {

            if (ps == ProductionProcess.KitProvision)
            {
                var production = await _appDbContext.ProductionUser.Where(x => x.ProductionProcess == ps && x.UserId == user)
               .Include(y => y.Production)
               .Select(z => new
               {
                   Id = z.Production.Id,
                   OrderNo = z.Production.OrderNo,
                   UretimAdi = z.Production.UretimAdi,
                   Aciklama = z.Production.Aciklama,
                   Quantity = z.Production.Quantity,
                   StartDate = z.Production.StartDate,
                   CreateDate = z.Production.CreateDate,
                   previousProcess = _appDbContext.RouteInfo.Where(d => d.ProductionId == z.Production.Id && d.State == true &&
                                                             d.Order <= _appDbContext.RouteInfo.Where(l => l.ProductionId == z.Production.Id && l.ProductionProcess == ps)
                                                             .FirstOrDefault().Order
                                                             ).OrderByDescending(g => g.Id).FirstOrDefault().ProductionProcess
               })
               .OrderByDescending(x => x.Id)
               .ToListAsync();
                return new ResponseModel(production);
            }else
               
            {
                var production = await _appDbContext.ProductionUser.Where(x => x.ProductionProcess == ps && x.UserId == user)
               .Include(y => y.Production)
               .Select(z => new
               {
                   Id = z.Production.Id,
                   OrderNo = z.Production.OrderNo,
                   UretimAdi = z.Production.UretimAdi,
                   Aciklama = z.Production.Aciklama,
                   Quantity = z.Production.Quantity,
                   StartDate = z.Production.StartDate,
                   CreateDate = z.Production.CreateDate,
                   previousProcess =
                   _appDbContext.RouteInfo.Where(d => d.ProductionId == z.Production.Id && d.State == true &&
                                                             d.Order < _appDbContext.RouteInfo.Where(l => l.ProductionId == z.Production.Id && l.ProductionProcess == ps)
                                                             .FirstOrDefault().Order
                                                             ).OrderByDescending(g => g.Id).FirstOrDefault().ProductionProcess
               })
               .OrderByDescending(x => x.Id)
               .ToListAsync();
                return new ResponseModel(production);
            }


        }       
    }

    public async Task<ResponseModel> GetAllQrCodeDetail(int productionId)
    {
        var qrcodeAll = await _appDbContext.ProductionOperations
            .Select(t => new
            {
                ProductionId = t.ProductionId,
                Qrcode = t.QrCode,
                FeedlerData = t.FeedlerData,
                UserInfo = _appDbContext.User.Where(u => u.Id == t.CreatorId).FirstOrDefault().Ad + " " + _appDbContext.User.Where(u => u.Id == t.CreatorId).FirstOrDefault().Soyad,
                CreateDate = t.CreateDate
            })
            .Where(y => y.ProductionId == productionId).ToListAsync();

        List<object> obj = new();

        foreach (var item in qrcodeAll)
        {

            List<int> dataS = JsonConvert.DeserializeObject<List<int>>(item.FeedlerData);

            var data = await _appDbContext.SetupVerificationDetails.Include(t => t.SetupVerification).ThenInclude(x => x.Production)
                                                        .Where(y => dataS.Contains(y.Id)).Select(y => new
                                                        {
                                                            Id = y.Id,
                                                            Material = y.Material,
                                                            PartyNumber = y.PartyNumber,
                                                            Qrcode = item.Qrcode,
                                                            ProductionId = item.ProductionId,
                                                            UserInFo = item.UserInfo,
                                                            CreateDate = item.CreateDate
                                                        }).ToListAsync();

            obj.AddRange(data);

        }

        return new ResponseModel(obj);

    }

    public async Task<ProductionDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<ProductionDtoQ>(entity);
    }
    
    public async Task<ProductionOperationDtoQ> GetOperationState(int id,int routeId )
    {
        var entity =  new ProductionOperationDtoQ()
        {
            BeginState = await _appDbContext.WorkProcessRouteTimeHistories.AnyAsync(x=> x.WorkProcessRoute.ProductionId == id && x.WorkProcessRouteId == routeId),
            ElapsedTime = TimeSpan.FromSeconds(await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking().Where(x=> x.WorkProcessRoute.ProductionId == id && x.WorkProcessRouteId == routeId && 
                                                               ( x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Start || x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Resume))
                                                               .SumAsync(x => x.ElapsedTime.TotalSeconds)).ToString(@"hh\:mm\:ss"),
            DownTime = TimeSpan.FromSeconds(await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking().Where(x => x.WorkProcessRoute.ProductionId == id && x.WorkProcessRouteId == routeId &&
                                                               (x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Stop || x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Pause))
                                                             .SumAsync(x=> x.ElapsedTime.TotalSeconds)).ToString(@"hh\:mm\:ss"),
            ElapsedDay = Math.Round(await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking().Where(x => x.WorkProcessRoute.ProductionId == id && x.WorkProcessRouteId == routeId &&
                                                               (x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Start || x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Resume))
                                                             .SumAsync(x => x.ElapsedTime.TotalDays ), 0, MidpointRounding.ToZero).ToString(),
            //ProductionOrderNo =  _appDbContext.Production.Where(x=> x.Id == id ).FirstOrDefault().OrderNo,
            //ProductionStartDate =  _appDbContext.ProductionTimeProcess.Where(x=> x.ProductionId == id && x.ProductionProcess == ps && x.ProductionTimeStatus == ProductionTimeStatus.Start).FirstOrDefault()?.StartDate.ToString("dd:MM:yyyy HH:mm"),
            StopState = await _appDbContext.WorkProcessRouteTimeHistories.AsNoTracking().AnyAsync(x=> x.WorkProcessRoute.ProductionId == id && x.WorkProcessRouteId == routeId && x.WorkProcessRouteTimeStatus == WorkProcessRouteTimeStatus.Stop),
        };
        return entity;
    }
    
    public async Task<ResponseModel> SetEstimatedTime(int id,int? estimatedTime,int? panelCardCount)
    {
        var data = _appDbContext.Production.Where(x => x.Id == id).FirstOrDefault();
        if (data is not null)
        {
            data.EstimatedTime = estimatedTime;
            data.PanelCardCount = panelCardCount;
            _appDbContext.Production.Update(data);
            await _appDbContext.SaveChangesAsync();
             
            ResponseModel rm = new() {Success = true};
        }
        ResponseModel rms = new() {Success = false};
        return rms;
    }
  
   
    public async Task<ResponseModel> Add(ProductionDtoC dto)
    {  
        var entity = _mapper.Map<Production>(dto);
        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> Delete(int id)
    {
        Production production = _appDbContext.Production.Where(x => x.Id == id).FirstOrDefault();


        if(production is not null)
        {
            ProductionLog productionLog = _appDbContext.ProductionLog.Where(x => x.ProductionId == id 
            //&&
            //x.ProductionProcess == ProductionProcess.KitProvision
            ).FirstOrDefault();
            if (productionLog != null)
            {
                return new ResponseModel { Success = false, Message = "Islem Kaydi Mevcut" };
            }
            else
            {
                _appDbContext.Production.Remove(production);
                await _appDbContext.SaveChangesAsync();
                return new ResponseModel { Success = true };
            }
        }

        return new ResponseModel { Success = false, Message = "Uretim Emri Bulunamadi" };




    }

}