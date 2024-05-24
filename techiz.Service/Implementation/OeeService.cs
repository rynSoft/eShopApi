using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using LinqKit;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using NpgsqlTypes;
using techiz.Domain;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class OeeService : IOeeService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public OeeService(
           IAppDbContext appDbContext,
           IMapper mapper,
           IHttpContextAccessor httpContextAccessor)
    {
        _mapper = mapper;
        _appDbContext = appDbContext;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<ResponseModel> GetOeeList()
    {
        //var ss = await _appDbContext.Viewsa.FromSqlRaw("SELECT  * FROM public.ooecalc;").AsNoTracking().ToListAsync();

        return new ResponseModel(null);
    }

    public async Task<ResponseModel> GetOeeListORM()
    {

          List<int> molas = _appDbContext.RestCause.Where(x => x.UseOee).Select(x => x.Id).ToList();

            var ss = await _appDbContext.ShiftTargetParameters
                                    .Where(x=> x.IsFinished && DateTimeOffset.Now.Date.AddDays(-1) <= x.CreateDate)
                                    .Include(x=>x.ProductionOperations).Include(x=>x.ProductionTimeProcess)
                                    .Select(x=> new
                                    {
                                        x.Id,
                                        LineAd = x.Line.Name,
                                        VardiyaAd = x.ShiftDefinition.Name,
                                        Operator = x.User.UserName,
                                        ProductionId = x.ProductionOperations.FirstOrDefault().ProductionId.ToString(),
                                        Dates = x.CreateDate.Value.Date,
                                        Product = x.ProductionOperations.FirstOrDefault().Production.UretimAdi,
                                        ShiftBeginTime = string.Format("{0:HH\\:mm}", x.StartDate),
                                        ShiftEndTime = string.Format("{0:HH\\:mm}", x.EndDate),
                                        BreakTime = string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) && y.ProductionProcess == ProductionProcess.ProductionProcess)
                                                                                                                             .Sum(y => y.ElapsedTime.TotalMinutes))),
                                        TotalWork = string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes)  -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) && y.ProductionProcess == ProductionProcess.ProductionProcess)
                                                                                                                            .Sum(y => y.ElapsedTime.TotalMinutes)
                                        )),

                                       TotalStops = string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => !molas.Contains((int)y.RestCauseId) &&
                                                                                        y.ProductionTimeStatus == Domain.Enum.ProductionTimeStatus.Pause &&
                                                                                        y.ProductionProcess == ProductionProcess.ProductionProcess
                                                                                       ).Sum(t => t.ElapsedTime.TotalMinutes))),
                                        TotalWorkHour = (TimeSpan.Parse(string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes)  -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) && y.ProductionProcess == ProductionProcess.ProductionProcess)
                                                                                                       .Sum(y => y.ElapsedTime.TotalMinutes
                                                          )))) 
                                        
                                        -

                                        TimeSpan.Parse(string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => !molas.Contains((int)y.RestCauseId) &&
                                                                                        y.ProductionTimeStatus == Domain.Enum.ProductionTimeStatus.Pause &&
                                                                                        y.ProductionProcess == ProductionProcess.ProductionProcess
                                                                                       ).Sum(t => t.ElapsedTime.TotalMinutes)))) ),

                                        TotalWorkMinute = ( TimeSpan.Parse(string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes) -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) && y.ProductionProcess == ProductionProcess.ProductionProcess)
                                                                                                       .Sum(y => y.ElapsedTime.TotalMinutes
                                                          ))))

                                        -

                                        TimeSpan.Parse(string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => !molas.Contains((int)y.RestCauseId) &&
                                                                                        y.ProductionTimeStatus == Domain.Enum.ProductionTimeStatus.Pause &&
                                                                                        y.ProductionProcess == ProductionProcess.ProductionProcess
                                                                                       ).Sum(t => t.ElapsedTime.TotalMinutes))))).TotalMinutes,

                                        LoadingLevel =((TimeSpan.Parse(
                                                                             string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes) -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) &&
                                                                                                       y.ProductionProcess == ProductionProcess.ProductionProcess).Sum(y => y.ElapsedTime.TotalMinutes))))
                                                       -
                                                          TimeSpan.Parse(
                                                                             string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => !molas.Contains((int)y.RestCauseId) &&
                                                                                        y.ProductionTimeStatus == Domain.Enum.ProductionTimeStatus.Pause &&
                                                                                        y.ProductionProcess == ProductionProcess.ProductionProcess
                                                                                       ).Sum(t => t.ElapsedTime.TotalMinutes)))))
                                                      /
                                                       (TimeSpan.Parse(
                                                          string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes) -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) &&
                                                                                                       y.ProductionProcess == ProductionProcess.ProductionProcess).Sum(y => y.ElapsedTime.TotalMinutes))))
                                                        ) * 100),



                                        TeoricSpeed = x.TheoreticalSpeed,
                                        ProducedCard = x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count(), // üretilen kart
                                        PerformanceLevel = (double)x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count(),
                                        DurableCard = x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count() - x.NumberOfCard, // sağlam kart
                                        ImprorerCard = x.NumberOfCard, // Uygunsu Kart
                                        QualityLevel = x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count() > 0 ?
                                        Convert.ToInt16((((double)(((x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count()) - x.NumberOfCard) - x.NumberOfCard))
                                                        /
                                                        (double)x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count()) * 100) : 0,


                                        //ProducedCard = 4200, // üretilen kart
                                        //PerformanceLevel = (double)4200,
                                        //DurableCard = 4200 - x.NumberOfCard, // sağlam kart
                                        //ImprorerCard = x.NumberOfCard, // Uygunsu Kart
                                        //QualityLevel = x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count() > 0 ?
                                        //Convert.ToInt16((((double)(((4200) - x.NumberOfCard) - x.NumberOfCard))
                                        //                /
                                        //                (double)4200) * 100) : 0,

                                    })
                                    .AsNoTracking()
                                     .OrderBy(x => x.Dates)
                                    .ToListAsync();

        return new ResponseModel(ss);
    }


    public async Task<ResponseModel> GetOeeListORMFilter(ShiftTargetParametersDtoQ shiftTargetParameters)
    {
        List<int> molas = _appDbContext.RestCause.Where(x => x.UseOee).Select(x => x.Id).ToList();

        Expression<Func<ShiftTargetParameters, bool>> filter = PredicateBuilder.New<ShiftTargetParameters>(true);

        filter = filter.And(x => x.IsFinished);

        if (shiftTargetParameters.LineId != null)
        {
            filter = filter.And(x => x.LineId == shiftTargetParameters.LineId);
        }

        if (shiftTargetParameters.UserId != null)
        {
            filter = filter.And(x => x.UserId == shiftTargetParameters.UserId);
        }
        if (shiftTargetParameters.ShiftDefinitionId != null)
        {
            filter = filter.And(x => x.ShiftDefinitionId == shiftTargetParameters.ShiftDefinitionId);
        }
        if (shiftTargetParameters.UserId != null)
        {
            filter = filter.And(x => x.UserId == shiftTargetParameters.UserId);
        }

        if (shiftTargetParameters.CreateDate != null)
        {
            filter = filter.And(x => shiftTargetParameters.CreateDate <= x.CreateDate);
        }
        if (shiftTargetParameters.EditDate != null)
        {
            filter = filter.And(x => shiftTargetParameters.EditDate.Value.AddDays(1) >= x.CreateDate );
        }


        var ss = await _appDbContext.ShiftTargetParameters
                                    .Where(filter)
                                    .Include(x => x.ProductionOperations ).Include(x => x.ProductionTimeProcess)
                                    .Select(x => new
                                    {
                                        x.Id,
                                        LineAd = x.Line.Name,
                                        VardiyaAd = x.ShiftDefinition.Name,
                                        Operator = x.User.UserName,
                                        ProductionId = x.ProductionOperations.FirstOrDefault().ProductionId.ToString(),
                                        Dates = x.CreateDate.Value.Date,
                                        Product = x.ProductionOperations.FirstOrDefault().Production.UretimAdi,
                                        ShiftBeginTime = string.Format("{0:HH\\:mm}", x.StartDate),
                                        ShiftEndTime = string.Format("{0:HH\\:mm}", x.EndDate),
                                        BreakTime = string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) && y.ProductionProcess == ProductionProcess.ProductionProcess)
                                                                                                                             .Sum(y => y.ElapsedTime.TotalMinutes))),
                                        TotalWork = string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes) + 1 -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) && y.ProductionProcess == ProductionProcess.ProductionProcess)
                                                                                                                            .Sum(y => y.ElapsedTime.TotalMinutes)
                                        )),

                                        TotalStops = string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => !molas.Contains((int)y.RestCauseId) &&
                                                                                         y.ProductionTimeStatus == Domain.Enum.ProductionTimeStatus.Pause &&
                                                                                         y.ProductionProcess == ProductionProcess.ProductionProcess
                                                                                       ).Sum(t => t.ElapsedTime.TotalMinutes))),
                                        TotalWorkHour = (TimeSpan.Parse(string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes) + 1 -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) && y.ProductionProcess == ProductionProcess.ProductionProcess)
                                                                                                       .Sum(y => y.ElapsedTime.TotalMinutes
                                                          ))))

                                        -

                                        TimeSpan.Parse(string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => !molas.Contains((int)y.RestCauseId) &&
                                                                                        y.ProductionTimeStatus == Domain.Enum.ProductionTimeStatus.Pause &&
                                                                                        y.ProductionProcess == ProductionProcess.ProductionProcess
                                                                                       ).Sum(t => t.ElapsedTime.TotalMinutes))))),

                                        TotalWorkMinute = (TimeSpan.Parse(string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes) -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) && y.ProductionProcess == ProductionProcess.ProductionProcess)
                                                                                                       .Sum(y => y.ElapsedTime.TotalMinutes
                                                          ))))

                                        -

                                        TimeSpan.Parse(string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => !molas.Contains((int)y.RestCauseId) &&
                                                                                        y.ProductionTimeStatus == Domain.Enum.ProductionTimeStatus.Pause &&
                                                                                        y.ProductionProcess == ProductionProcess.ProductionProcess
                                                                                       ).Sum(t => t.ElapsedTime.TotalMinutes))))).TotalMinutes,

                                        LoadingLevel = ((TimeSpan.Parse(
                                                                             string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes) -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) &&
                                                                                                       y.ProductionProcess == ProductionProcess.ProductionProcess).Sum(y => y.ElapsedTime.TotalMinutes))))
                                                       -
                                                          TimeSpan.Parse(
                                                                             string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes(x.ProductionTimeProcess.Where(y => !molas.Contains((int)y.RestCauseId) &&
                                                                                        y.ProductionTimeStatus == Domain.Enum.ProductionTimeStatus.Pause &&
                                                                                        y.ProductionProcess == ProductionProcess.ProductionProcess
                                                                                       ).Sum(t => t.ElapsedTime.TotalMinutes)))))
                                                      /
                                                       (TimeSpan.Parse(
                                                          string.Format("{0:hh\\:mm}", TimeSpan.FromMinutes((x.DifferanceDate.TotalMinutes) -
                                                                                                       x.ProductionTimeProcess.Where(y => molas.Contains((int)y.RestCauseId) &&
                                                                                                       y.ProductionProcess == ProductionProcess.ProductionProcess).Sum(y => y.ElapsedTime.TotalMinutes))))
                                                        ) * 100),



                                        TeoricSpeed = x.TheoreticalSpeed,
                                        //TargetProduct = x.TargetCardCount, // Üretilebilecek Panel Adedi
                                        ProducedCard = x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count(), // üretilen kart
                                        //PerformanceLevel = Convert.ToInt32(((double)x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count() /  (double)x.TargetCardCount)  * 100),
                                        PerformanceLevel = (double)x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count(),
                                        DurableCard = x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count() - x.NumberOfCard, // sağlam kart
                                        ImprorerCard = x.NumberOfCard,
                                        //, // Uygunsu Kart
                                        QualityLevel = x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count() > 0 ?
                                                        Convert.ToInt16((((double)(((x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count()) - x.NumberOfCard) - x.NumberOfCard))
                                                        /
                                                        (double)x.ProductionOperations.Where(z => z.ShiftTargetParametersId == x.Id).Count()) * 100) : 0,
                                    })
                                    .AsNoTracking()
                                     .OrderBy(x => x.Dates)
                                    .ToListAsync();
        return new ResponseModel(ss);
    }
    public async Task<List<RestCauseElapsedDTO>> GetRestCauseTimeGroup(int shiftTargetParametersId)
    {
        var production = await _appDbContext.ProductionTimeProcess.Include(y => y.RestCause)
                                                                   .Where(x => x.ShiftTargetParametersId == shiftTargetParametersId &&
                                                                             !x.RestCause.UseOee &&
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

    public async Task<ResponseModel> GetFeederStop()
    {

        return new ResponseModel(_mapper.Map<List<LineDtoQ>>(await _appDbContext.Line.Where(y => y.Active).ToListAsync()));
    }

    public async Task<ResponseModel> GetSmdRapor()
    {
        return new ResponseModel(_mapper.Map<List<LineDtoQ>>(await _appDbContext.Line.Where(y => y.Active).ToListAsync()));
    }
    

}