using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class ShiftDefinitionProcessService : IShiftDefinitionProcessService
{
    private readonly IRepository<ShiftDefinitionProcess> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public ShiftDefinitionProcessService(IRepository<ShiftDefinitionProcess> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return new ResponseModel(_mapper.Map<List<ShiftDefinitionProcessDtoQ>>
                                (await _appDbContext.ShiftDefinitionProcess.Include(y=> y.Line).Include(z=> z.ShiftDefinition).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> Add(ShiftDefinitionProcessDtoC dto)
    {  
        if (_appDbContext.ShiftDefinitionProcess.Where(x=> x.LineId == dto.LineId && x.ShiftDefinitionId == dto.ShiftDefinitionId && x.CreateDate.Value.Date == DateTime.Today  ).Any())
            return new ResponseModel(Message: "Daha önce kayıt eklenmiş", false);
        var entity = _mapper.Map<ShiftDefinitionProcess>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(ShiftDefinitionProcessDtoC dto)
    {
        var entity = _mapper.Map<ShiftDefinitionProcess>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        ShiftDefinitionProcess ShiftDefinitionProcessSingle = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(ShiftDefinitionProcessSingle)));
    }

    public async Task<ResponseModel> GetUserShiftDefinition(Guid userId)
    {
    //BU SERVİS KULLANILMIYOR YERİNE GETTODAY KULLANILDI FRONTENDDE  YORUMDA
        DateTime tsDateTimeComperision = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 00);
        if (tsDateTimeComperision.Hour < 8)
        {
            tsDateTimeComperision = tsDateTimeComperision.AddDays(1);
        }

        var vardiyaDefinitionList = await _appDbContext.ShiftDefinitionProcess.Include(x => x.ShiftDefinition).Where(x=>x.UserId==userId)
            .Select(x => new
            {
                Id = x.Id,
                StartDates = DateTime.Today.Add(x.ShiftDefinition.StartDate),
                EndDates = x.ShiftDefinition.StartDate > x.ShiftDefinition.EndDate ? DateTime.Today.AddDays(1).Add(x.ShiftDefinition.EndDate) : DateTime.Today.Add(x.ShiftDefinition.EndDate)
            }).ToListAsync();

        var vardiyaDefinitionCurrent = vardiyaDefinitionList.Where(y => y.StartDates < tsDateTimeComperision && y.EndDates > tsDateTimeComperision).FirstOrDefault();

        if (vardiyaDefinitionCurrent != null)
        {

            return new ResponseModel(Message: vardiyaDefinitionCurrent.Id.ToString(), true);
        }
        else
        {
            return new ResponseModel(Message: "Kullaniciya Ait Vardiya Mevcut Degil", false);
        }

    }
    public async Task<ResponseModel> AddUserShiftDefinition(ShiftDefinitionProcessDtoC dto)
    {
        TimeSpan time = DateTimeOffset.Now.TimeOfDay;
        List< ShiftDefinition> shiftDefinition = _appDbContext.ShiftDefinition.Where(x=>x.StartDate<=time && x.EndDate >= time).ToList();

        if (shiftDefinition != null)
        {
            dto.ShiftDefinitionId= shiftDefinition[0].Id;
            var entity = _mapper.Map<ShiftDefinitionProcess>(dto);
            return await _repository.AddAsync(entity);
        }
        else
        {
            return new ResponseModel(Message: "Vardiya Mevcut Deðil", false);
        }

    }


}