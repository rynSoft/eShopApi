using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class ShiftTargetParametersService : IShiftTargetParametersService
{
    private readonly IRepository<ShiftTargetParameters> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public ShiftTargetParametersService(IRepository<ShiftTargetParameters> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ShiftTargetParametersDtoQ>>(await _appDbContext.ShiftTargetParameters.OrderBy(x=> x.Id).ToListAsync()));
    }

    public async Task<ResponseModel> GetToday(Guid userId)
    {

        var vardiyaDefinitionCurrent = _mapper.Map<ShiftTargetParametersDtoQ>(_appDbContext.ShiftTargetParameters.Include(x=>x.ShiftDefinition).
                Where(x => x.CreateDate.Value.DateTime.Date == DateTime.Today && x.UserId == userId && x.IsFinished!=true).FirstOrDefault());

        if (vardiyaDefinitionCurrent != null)
        {
            vardiyaDefinitionCurrent.TotalProductionCard = _appDbContext.ProductionOperations.Where(y => y.ShiftTargetParametersId == vardiyaDefinitionCurrent.Id).Count();
            return new ResponseModel(vardiyaDefinitionCurrent);
        }
        else
        {
            var todayDefinition = _mapper.Map<ShiftTargetParametersDtoQ>(_appDbContext.ShiftTargetParameters.
                 Where(x => x.CreateDate.Value.DateTime.Date == DateTime.Today && x.UserId == userId).FirstOrDefault());
            return new ResponseModel(Message: "Vardiya Mevcut Degil", todayDefinition!=null ?false:true);
        }
          }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    

    public async Task<ResponseModel> GetNowShiftTarget()
    {
        DateTime tsDateTimeComperision = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 00);
        var vardiyaDefinitionList = await _appDbContext.ShiftDefinition
            .Select(x => new
            {
                Id = x.Id,
                VardiyaAdi=x.Name,
                StartDates = DateTime.Today.Add(x.StartDate),
                EndDates = x.StartDate > x.EndDate ? DateTime.Today.AddDays(1).Add(x.EndDate) : DateTime.Today.Add(x.EndDate)
            }).ToListAsync();


        if (tsDateTimeComperision.Hour < 8)
        {
            tsDateTimeComperision = tsDateTimeComperision.AddDays(1);
        }

        var vardiyaDefinitionCurrent = vardiyaDefinitionList.Where(y => y.StartDates <= tsDateTimeComperision && y.EndDates >= tsDateTimeComperision).FirstOrDefault();

        if (vardiyaDefinitionCurrent != null)
        {
      
            return new ResponseModel(vardiyaDefinitionCurrent);
        }
        else
        {
            return new ResponseModel(Message: "Vardiya Mevcut Degil", false);
        }
    }
    public async Task<ResponseModel> Add(ShiftTargetParametersDtoC dto)
    {
            var entity = _mapper.Map<ShiftTargetParameters>(dto);
            return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(ShiftTargetParametersDtoC dto)
    {
        dto.IsFinished = true;
        var entity = _mapper.Map<ShiftTargetParameters>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }
    public async Task<ResponseModel> Delete(int id)
    {
        ShiftTargetParameters restCause = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(restCause)));
    }


}