using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;
using static techiz.Domain.Utilities.Permissions;
namespace techiz.Service.Implementation;

public class DashboardService : IDashboardService
{
    private readonly IMapper _mapper;
    private IAppDbContext _appDbContext;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly IRepository<Domain.Entities.Production> _repository;
    public DashboardService(
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

    public async Task<ResponseModel> GetProduction_1(int LineId)
    {
        var productionId = await _appDbContext.ShiftTargetParameters
                                               .Where(y => y.LineId == LineId && y.ProductionOperations.Count > 0)
                                               .Select(y => new {
                                                   ProductionId = y.ProductionOperations != null ? y.ProductionOperations.FirstOrDefault().ProductionId : 0,
                                                   CreateDate = y.CreateDate.Value.Date
                                               }).OrderByDescending(y => y.CreateDate).FirstOrDefaultAsync();

        if (productionId is null)
            return new ResponseModel();

        var  currentShift = await _appDbContext.ShiftTargetParameters
                                               .Where(y => y.LineId == LineId && y.ProductionOperations.Count > 0)
                                               .Select(y =>  new {
                                                    UretimNo = y.ProductionOperations.FirstOrDefault().Production.OrderNo,
                                                   VardiyaUser = y.User.Ad +" "+ y.User.Soyad,
                                                   CreateDate = y.CreateDate,
                                                   Dates = DateTime.Now.Date,
                                                   VardiyaRange = $"({y.StartDate.TimeOfDay} - {y.EndDate.TimeOfDay})",
                                                   ToplamUretilecekKart = y.ProductionOperations.FirstOrDefault().Production.Quantity.ToString(),
                                                   UretimAdis = y.ProductionOperations.FirstOrDefault().Production.UretimAdi,
                                                   RestCauseElapsed = GetRestCauseTimeGroup(LineId).Result,
                                                   GetProductionDatesCount= GetProductionDatesCount(productionId.ProductionId).Result,
                                                   GetProductionHoursCount = GetProductionHoursCount(productionId.ProductionId).Result,
                                                   ToplamUretilenKart = _appDbContext.ProductionOperations.Where(z => z.ProductionId == y.ProductionOperations.FirstOrDefault().ProductionId).Count() * y.ProductionOperations.FirstOrDefault().Production.PanelCardCount,
                                                   UretilenKart = y.ProductionOperations.Where(z => z.ShiftTargetParametersId == y.Id).Count() * y.ProductionOperations.FirstOrDefault().Production.PanelCardCount,
                                                   VardiyaHedefi = y.TargetCardCount,
                                                   KalanKart = y.ProductionOperations.FirstOrDefault().Production.Quantity - (_appDbContext.ProductionOperations.Where(z => z.ProductionId == y.ProductionOperations.FirstOrDefault().ProductionId).Count() * y.ProductionOperations.FirstOrDefault().Production.PanelCardCount),

                                               }).OrderByDescending(y=> y.CreateDate).FirstOrDefaultAsync();

        #region Eski kod
        //string userAdSoyad = await _appDbContext.User.Where(z => z.Id == productionOperations.CreatorId).Select(x => x.Ad + " " + x.Soyad).FirstOrDefaultAsync();

        //var production = await _appDbContext.Production.Where(z => z.Id == productionOperations.ProductionId)
        //                                    .Select(y => new
        //                                    {
        //                                        UretilenKart = vardiyadaUretilenKart,
        //                                        UretimNo = y.OrderNo,
        //                                        VardiyaUser = userAdSoyad,
        //                                        Dates = DateTime.Now.Date,
        //                                        VardiyaRange = $"({vardiyaDefinitionCurrent.StartDates.TimeOfDay} - {vardiyaDefinitionCurrent.EndDates.TimeOfDay})",
        //                                        VardiyaHedefi = vardiyaHedef != null ? vardiyaHedef.TargetQuantity : 0,
        //                                        ToplamUretilenKart = toplamUretilenKart,
        //                                        ToplamUretilecekKart = y.Quantity,
        //                                        KalanKart = y.Quantity - toplamUretilenKart,
        //                                        UretimAdis = y.UretimAdi,
        //                                        RestCauseElapsed = listRestCauseElapsed,
        //                                        GetProductionHoursCount = listProductionHourCount,

        //                                    }).FirstOrDefaultAsync();






        //var machineIds = await _appDbContext.Machine.Where(y => y.LineId == LineId).Select(y => y.Id).ToListAsync();

        //var productionOperations = await _appDbContext.ProductionOperations.Where(x => machineIds.Contains(x.MachineId)).OrderByDescending(y => y.Id).FirstOrDefaultAsync();


        //var listRestCauseElapsed = GetRestCauseTimeGroup(productionOperations.ProductionId).Result;
        //var listProductionHourCount = GetProductionHoursCount(productionOperations.ProductionId).Result;

        //DateTime tsDateTimeComperision = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 00);
 

     


        //var vardiyaDefinitionCurrent = vardiyaDefinitionList.Where(y => y.StartDates < tsDateTimeComperision && y.EndDates > tsDateTimeComperision).FirstOrDefault();


        //var vardiyaHedef = await _appDbContext.ShiftDefinitionProcess.Where(y => y.LineId == LineId && y.ShiftDefinitionId == vardiyaDefinitionCurrent.Id && y.CreateDate.Value.Date == DateTime.Today).FirstOrDefaultAsync();


        //_appDbContext.ProductionOperations.Where(y => y.ProductionId == productionOperations.ProductionId)

        //                                                                .ToList().ForEach(z => Console.WriteLine(z.CreateDate.Value.DateTime));

        //var vardiyadaUretilenKart = await _appDbContext.ProductionOperations.Where(y => y.ProductionId == productionOperations.ProductionId &&
        //                                                                                  vardiyaDefinitionCurrent.StartDates.AddHours(-3) < y.CreateDate.Value.DateTime
        //                                                                                 &&
        //                                                                                vardiyaDefinitionCurrent.EndDates.AddHours(-3) >= y.CreateDate.Value.DateTime
        //                                                                                ).Select(c => c.QrCode).Distinct().CountAsync();

        //var toplamUretilenKart = await _appDbContext.ProductionOperations.Where(y => y.ProductionId == productionOperations.ProductionId
        //                                                                               ).Select(c => c.QrCode).Distinct().CountAsync();



        //string userAdSoyad = await _appDbContext.User.Where(z => z.Id == productionOperations.CreatorId).Select(x => x.Ad + " " + x.Soyad).FirstOrDefaultAsync();

        //var production = await _appDbContext.Production.Where(z => z.Id == productionOperations.ProductionId)
        //                                    .Select(y => new
        //                                    {
        //                                        UretilenKart = vardiyadaUretilenKart,
        //                                        UretimNo = y.OrderNo,
        //                                        VardiyaUser = userAdSoyad,
        //                                        Dates = DateTime.Now.Date,
        //                                        VardiyaRange = $"({vardiyaDefinitionCurrent.StartDates.TimeOfDay} - {vardiyaDefinitionCurrent.EndDates.TimeOfDay})",
        //                                        VardiyaHedefi = vardiyaHedef != null ? vardiyaHedef.TargetQuantity : 0,
        //                                        ToplamUretilenKart = toplamUretilenKart,
        //                                        ToplamUretilecekKart = y.Quantity,
        //                                        KalanKart = y.Quantity - toplamUretilenKart,
        //                                        UretimAdis = y.UretimAdi,
        //                                        RestCauseElapsed = listRestCauseElapsed,
        //                                        GetProductionHoursCount = listProductionHourCount,

        //                                    }).FirstOrDefaultAsync();

        #endregion



        return new ResponseModel(currentShift);
    }


    public async Task<List<RestCauseElapsedDTO>> GetRestCauseTimeGroup(int lineId)
    {
        var currentShift = await _appDbContext.ShiftTargetParameters
                                     
                                       .Where(y => y.LineId == lineId && y.ProductionOperations.Count > 0)
                                       .Select(y =>  new { Id = y.Id }).OrderByDescending(z => z.Id).FirstOrDefaultAsync();

        if (currentShift is null)
            return new List<RestCauseElapsedDTO>();
        
        var production = await _appDbContext.ProductionTimeProcess.Include(y => y.RestCause)
                                                                   .Where(x => x.ShiftTargetParametersId == currentShift.Id &&
                                                                             x.ProductionProcess == ProductionProcess.ProductionProcess && !x.RestCause.Hanging)
                                                                   .GroupBy(y => y.RestCause.Name)
                                                                   .Select(d => new RestCauseElapsedDTO()
                                                                   {
                                                                       Name = d.Key,
                                                                       SumElapsedTime = Math.Round(d.Select(b => b.ElapsedTime.TotalMinutes).Sum(), 4, MidpointRounding.AwayFromZero)
                                                                   })
                                                                   .ToListAsync();
        return production;
    }

    public async  Task<List<ProductionHoursCount>> GetProductionHoursCount(int productionId)
    {
        var production = await _appDbContext.ProductionOperations
                                            .Where(x => x.ProductionId == productionId)
                                            .GroupBy(y => y.CreateDate.Value.Hour)
                                            .Select(d => new ProductionHoursCount()
                                            {
                                                Hour = d.Key,
                                                ProductionCount = d.Count()
                                            })
                                            .ToListAsync();
        return production;
    }

    private async Task<List<ProductionDatessCount>> GetProductionDatesCount(int productionId)
    {
        var production = await _appDbContext.ProductionOperations
                                            .Where(x => x.ProductionId == productionId)
                                            .GroupBy(y => y.CreateDate.Value.Date)
                                            .Select(d => new ProductionDatessCount()
                                            {
                                                Dates = d.Key,
                                                ProductionCount = d.Count()
                                            }).OrderBy(x=>x.Dates)
                                            .ToListAsync();
        return production;
    }

    public async Task<ResponseModel> GetProduction_4()
    {
        var production = await _appDbContext.Production.OrderByDescending(x => x.Id).ToListAsync();
        return new ResponseModel(production);
    }

    public async Task<ResponseModel> GetProduction_5()
    {
        var production = await _appDbContext.Production.OrderByDescending(x => x.Id).ToListAsync();
        return new ResponseModel(production);
    }

    public async Task<ResponseModel> GetProduction_6()
    {
        var production = await _appDbContext.Production.OrderByDescending(x => x.Id).ToListAsync();
        return new ResponseModel(production);
    }
}