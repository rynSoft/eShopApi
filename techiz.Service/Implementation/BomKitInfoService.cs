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

public class BomKitInfoService : IBomKitInfoService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IRepository<Domain.Entities.BomKitInfo> _repository;
    private readonly ILogger<BomKitInfoService> _logger;
    
    public BomKitInfoService(
           IAppDbContext appDbContext,
           IRepository<Domain.Entities.BomKitInfo> repository, 
           ILogger<BomKitInfoService> logger,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
        _logger = logger;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        _logger.LogError("asss");
        List<BomKitInfoDtoQ> bomKitInfo = _mapper.Map<List<Domain.Entities.BomKitInfo>,List<BomKitInfoDtoQ>>(_appDbContext.BomKitInfo
                                                                                      .Include(x=> x.Production).OrderByDescending(x=> x.Id).ToList());
        return new ResponseModel(bomKitInfo);
    }
            // IEnumerable<BomKitInfoDtoQ> bomKitInfo = _mapper.Map<IEnumerable<Domain.Entities.BomKitInfo>,IEnumerable<BomKitInfoDtoQ>>
                      //     (await _repository.GetAllAsync(x=>x.ProductionId == id ,include: y=> y.Include(a=> a.WareHouse) ));
    public async Task<IEnumerable<BomKitInfoDtoQ>> GetAllAsyncProductId(int id)
    {
        
       var result  = _appDbContext.BomKitInfo
           .Where(x=> x.ProductionId == id)
           .Select(x=> new BomKitInfoDtoQ()
        {
            Id = x.Id,
            Explanation = x.Explanation,
            Material = x.Material,
            PartyNumber = x.PartyNumber,
            Quantity = x.Quantity,
            RollerQuantity = x.RollerQuantity,
            Unit = x.Unit,
            ProductionId = x.ProductionId,
            Description = x.Description,
            IsKitProvided = x.IsKitProvided,
            IsKitPreperated = x.IsKitPreperated,
            IsSetupVerification = x.IsSetupVerification,
            SoureProductPlace = x.SoureProductPlace,
            WareHouseCode = x.WareHouse.Code,
            WareHouseId = x.WareHouse.Id,
            WareHouseName = x.WareHouse.Name,
            SetNo = x.SetNo
        }
       ).OrderBy(x=> x.Material);
            
        return result;
    }
    public async Task<BomKitInfoDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<BomKitInfoDtoQ>(entity);
    }
    
    public async Task<ResponseModel> Add(BomKitInfoDtoC dto)
    {  
  
        var entity = _mapper.Map<BomKitInfo>(dto);
        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> Update(BomKitInfoDtoU dto)
    {
        var entity = _mapper.Map<BomKitInfo>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }


    public async Task<ResponseModel> UpdateWareHouse(int productionId,int wareHouseId,string House)
    {

        var result = _appDbContext.BomKitInfo.Where(x => x.ProductionId == productionId&& x.WareHouseName== House).ToList() ;
        foreach (var item in result)
        {
            item.WareHouseId = wareHouseId;

            new ResponseModel((await _repository.UpdateAsync(item)));
        }
        return new ResponseModel(true);
    }
}