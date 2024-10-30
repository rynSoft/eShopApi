using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using eShop.Domain;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Enum;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class SetupVerificationDetailService : ISetupVerificationDetailService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IRepository<Domain.Entities.SetupVerificationDetails> _repository;
    private readonly ILogger<SetupVerificationService> _logger;
    
    public SetupVerificationDetailService(
           IAppDbContext appDbContext,
           IRepository<Domain.Entities.SetupVerificationDetails> repository, 
           ILogger<SetupVerificationService> logger,
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
        List<SetupVerificationDetailDto> SetupVerification = _mapper.Map<List<Domain.Entities.SetupVerificationDetails>,List<SetupVerificationDetailDto>>(_appDbContext.SetupVerificationDetails
                                                                                      .OrderByDescending(x=> x.Id).ToList());
        return new ResponseModel(SetupVerification);
    }

    public async Task<IEnumerable<SetupVerificationDetailDto>> GetAllAsyncProductionId(int id)
    {
        
       var result  = _appDbContext.SetupVerificationDetails
           
           .Select(x=> new SetupVerificationDetailDto()
        {
            Id = x.Id,
        }
       ).OrderBy(x=> x.Id);
            
        return result;
    }
    
    public  async Task<ResponseModel>  GetAllAsyncStateProductionId(int id,int machineId)
    {
        var result  = await _appDbContext.SetupVerificationDetails.Include(y=> y.SetupVerification)
                .Where(x=> x.SetupVerification.ProductionId == id && x.State == false && x.MachineId==machineId).ToListAsync();
  
        return new ResponseModel(result);
    }
    
    public async Task<SetupVerificationDetailDto> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<SetupVerificationDetailDto>(entity);
    }
    
    public async Task<ResponseModel> Add(SetupVerificationDetailDto dto)
    {  
        var entity = _mapper.Map<SetupVerificationDetails>(dto);
        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> Update(SetupVerificationDetailDto dto)
    {
        var entity = _mapper.Map<SetupVerificationDetails>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }
    
    public async Task<ResponseModel> CalcUsingQuantity(int productionId,string qrCode)
    {
        var newQrCode = qrCode.Substring(1, qrCode.Length - 1);
        
        var machineId = await _appDbContext.ProductionMachineMatch.Include(z=> z.Machine)
            .Where(x => x.State == true && x.ProductionId == productionId && x.Machine.BarcodeReaderId == qrCode.ToUpper().Substring(0, 1) )
            .Select(x=> x.MachineId) 
            .FirstOrDefaultAsync();
        
        var dataS =  _appDbContext.SetupVerificationDetails
            .Where(x =>  x.SetupVerification.ProductionId == productionId &&
                                           x.SetupVerification.MachineId == machineId &&   
                        x.State == true
        ).ToList();
        
        bool sendNewList = false; 
        foreach (var item in dataS)
        {
            bool sendNewListController = false;
            SetupVerificationDetails? newStateBomKit = null;
            int tempQuantity = 0;
            int fark = 0;
            
            var decrease  =
                _appDbContext.SetupVerificationInfo.Where(z =>
                    z.Barcode == item.Material && z.ProductionId == productionId && z.MachineId == machineId
                    && z.SetNo==item.SetNo).FirstOrDefault().Decrease;
           
            item.UsingQuantity = item.UsingQuantity + decrease;
            
            #region Kullanılan miktar eşit ve büyükse değişim yapılıyor 
            if (item.UsingQuantity > item.RollerQuantity && item.ChangingBomKitInfoId != 0)
            {
                item.State = false;
                tempQuantity = (int)item.UsingQuantity;
                item.IsCompleted = true;
                sendNewList = true;
                fark = (int)item.UsingQuantity - (int)item.RollerQuantity;
                item.UsingQuantity = item.RollerQuantity;
                 
                
                sendNewListController = true;
            }
            #endregion
         
            _appDbContext.SetupVerificationDetails.Update(item);
           
            #region Kullanılan miktar eşit ve büyükse değişime devam ediliyor 
            if (sendNewListController && item.ChangingBomKitInfoId != 0)
            {
              newStateBomKit =  _appDbContext.SetupVerificationDetails
                                               .Where(z => z.Id == item.ChangingBomKitInfoId)
                                               .FirstOrDefault();
            if(tempQuantity > item.RollerQuantity)
                {
                    newStateBomKit.UsingQuantity = fark;
                }
             newStateBomKit.State = true;
             newStateBomKit.SetNo = item.SetNo;
             _appDbContext.SetupVerificationDetails.Update(newStateBomKit);
             
            }
            {
            }
            #endregion
            
             #region  Change State

             try
             {
                 if (sendNewListController && item.ChangingBomKitInfoId!=0)
                 {
                     var NewPanelId = _appDbContext.ProductionOperations.Where(y => y.ProductionId == productionId && y.MachineId == machineId)
                         .OrderByDescending(z => z.Id).FirstOrDefault().Id;

                    

                    SetupVerificationDChangeDtoC dataChangeLog = new SetupVerificationDChangeDtoC()
                     {
                         ProductionId = productionId,
                         NewPanelId = NewPanelId,
                         OldPanelId = _appDbContext.ProductionOperations.Where(y=> y.ProductionId == productionId &&
                             y.MachineId == machineId &&
                             y.Id != NewPanelId).OrderByDescending(z=> z.Id).FirstOrDefault().Id,
                         SetupVerificationDetailsNewId  = item.ChangingBomKitInfoId,
                         SetupVerificationDetailsOldId = item.Id,
                         OldPanelQty = _appDbContext.SetupVerificationDetails.Where(y => y.Id == item.Id).FirstOrDefault().RollerQuantity,
                         NewPanelQty = _appDbContext.SetupVerificationDetails.Where(y => y.Id == item.ChangingBomKitInfoId).FirstOrDefault().RollerQuantity,
                     };
                     var entity = _mapper.Map<SetupVerificationDChange>(dataChangeLog);
                     entity.SetupVerificationDetailsNewId = item.ChangingBomKitInfoId;
                     entity.MachineId = machineId;
                     entity.SetupVerificationDetailsOldId = item.Id;
            
                     _appDbContext.SetupVerificationDChange.Add(entity);
                 }
             }
             catch (Exception e)
             {
                 _logger.LogError("Error : qrcode değiştirme : " +e.Message);
             }
           
            #endregion
            
        }
        await _appDbContext.SaveChangesAsync();
        
        return new ResponseModel(Data : new
        {
            machineId = machineId,
            data = sendNewList
        } );
    }
    
    public async Task<ResponseModel> GetMaterialCodeWithBomKit(string materialCode,int productionId,int setNo,int machineId)
    {
        // var data = _appDbContext.SetupVerificationDetails.Include(x=>x.SetupVerification).Where(x =>
        //         x.Material == materialCode  && x.IsCompleted == false && x.SetupVerification.ProductionId == productionId)
        //     .ToList();
        var data = _appDbContext.SetupVerificationDetails.Include(x=>x.SetupVerification).Where(x =>
                x.Material == materialCode  && x.SetupVerification.ProductionId == productionId && x.SetNo==setNo&& x.MachineId==machineId).OrderByDescending(x=>x.Id)
            .ToList();
        
        return new ResponseModel(data);
    }
    
    public async Task<ResponseModel> YetAddedSetNoOnFeedler(int productionId,string materialCode)
    {
        var dataInfo =  _appDbContext.SetupVerificationInfo
                                                         .Where(x => x.ProductionId == productionId)
                                                         .Select(x=> x.SetNo)
                                                         .ToList();
        
        var data =  _appDbContext.SetupVerificationDetails.Where(x =>
                !dataInfo.Contains(x.SetNo) && x.SetupVerification.ProductionId == productionId )
            .ToList();
        
        if (data is not null)
        {
            return  new ResponseModel( data);
        }
        return null;
    }
    
 
}