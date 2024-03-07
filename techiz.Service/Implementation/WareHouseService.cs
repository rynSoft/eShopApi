using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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

public class WareHouseService : IWareHouseService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IRepository<Domain.Entities.WareHouse> _repository;

    private readonly ILogger<WareHouseService> _logger;
    private readonly IBomKitInfoService _bomKitInfoService;
    public WareHouseService(
           IAppDbContext appDbContext,
           IRepository<Domain.Entities.WareHouse> repository,
      
           ILogger<WareHouseService> logger,
           IBomKitInfoService bomKitInfoService,
           IMapper mapper)
    {

        _bomKitInfoService = bomKitInfoService;
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
        _logger = logger;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        List<WareHouseDtoQ> wareHouse = _mapper.Map<List<Domain.Entities.WareHouse>,List<WareHouseDtoQ>>(_appDbContext.WareHouse.ToList());
        return new ResponseModel(wareHouse);
    }
    public async Task<WareHouseDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<WareHouseDtoQ>(entity);
    }
    public async Task<int?> GetBynemToId(string name)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Name == name);
        if (entity is not null)
           return entity.Id;
        else
        {
            return null;
        }
    }

    public async Task<ResponseModel> AddNewBarcode(WareHouseDtoBU dto)
    {
        try
        {
            var BarcodController = await _repository.GetSingleAsync(x => x.Name == dto.wareHouseDtoU.Name && x.Code == dto.wareHouseDtoU.Code);
            if (BarcodController is  null)
            {
                //DEPO MEVCUT DEGÝLSE  DEPO EKLENÝR VE  Yeni id degeri ile bomkit listesi güncellenir
                var entity = _mapper.Map<WareHouse>(dto.wareHouseDtoU);
                var wareHouseId = await _repository.AddAsync(entity);
                if (wareHouseId is not null)
                {
                     await _bomKitInfoService.UpdateWareHouse(dto.productionId, entity.Id, dto.wareHouseDtoU.Name);                  
                }
 
            }
            else
            {
                  await _bomKitInfoService.UpdateWareHouse(dto.productionId, BarcodController.Id, dto.wareHouseDtoU.Name);
                //DEPO ZATEN MEVCUTSA  VE  ESKÝ KAYITLARDA WAREHOUSE NULL ÝSE CALISIR          
            }    
            return new ResponseModel(true);
        }
        catch
        {
            return new ResponseModel(false);
        } 
    }


    public async Task<ResponseModel> Add(WareHouseDtoC dto)
    {
        var BarcodController = await _repository.GetSingleAsync(x => x.Name == dto.Name || x.Code == dto.Code);
        if(BarcodController is null)
        {
            var entity = _mapper.Map<WareHouse>(dto);
            return await _repository.AddAsync(entity);
        }
        else
        {
            return new ResponseModel(false);
        }
    }

    public async Task<ResponseModel> Update(WareHouseDtoU dto)
    {
        var entity = _mapper.Map<WareHouse>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }
    public async Task<ResponseModel> Delete(int id)
    {
        Domain.Entities.WareHouse wareHouse =  await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(wareHouse)));  
    }

}