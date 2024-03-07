using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using techiz.Domain;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class ProductionOperationsService : IProductionOperationsService
{
    private readonly IRepository<ProductionOperations> _repository;
    private readonly IMapper _mapper;
    private readonly ISetupVerificationDetailService _setupVerificationDetailService;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IAppDbContext _appDbContext;
    
    public ProductionOperationsService(IRepository<ProductionOperations> repository, 
           IAppDbContext appDbContext,
           IHttpContextAccessor httpContextAccessor,
           ISetupVerificationDetailService setupVerificationDetailService,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _setupVerificationDetailService = setupVerificationDetailService;
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ProductionOperationsDtoQ>>(await _appDbContext.ProductionOperations.OrderBy(x=> x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> GetAllAsyncProductId(int productionId)
    {
        return  new ResponseModel(_mapper.Map<List<ProductionOperationsDtoQ>>(await _appDbContext.ProductionOperations
            .Where(i=> i.ProductionId ==productionId).OrderByDescending(i => i.Id).Take(150).ToListAsync()));
    }

    public async Task<ResponseModel> GetAllProductionAndMachne(int productionId,int machineId)
    {
        return new ResponseModel(_mapper.Map<List<ProductionOperationsDtoQ>>(await _appDbContext.ProductionOperations
            .Where(i => i.ProductionId == productionId && i.MachineId==machineId).OrderByDescending(i => i.Id).Take(150).ToListAsync()));
    }

    public async Task<ResponseModel> GetAllProductionTimeDetail(int productionId)
    {
      List<int> prDetail= await _appDbContext.ProductionOperations.Where(i => i.ProductionId == productionId).Select(x=>x.GecenSure).ToListAsync();
        int gecenSure = 0;
        int panelSayisi = prDetail.Count();

        ProductionOperationPanel panelDetail = new ProductionOperationPanel();
        foreach (var pr in prDetail)
        {
            gecenSure += pr;
        }
        
        panelDetail.ToplamGecenSure = gecenSure;
        panelDetail.ToplamPanelSayisi = prDetail.Count;
        return new ResponseModel(panelDetail);

    }

    public async Task<ResponseModel> GetAllProductionTimeDetailMachine(int productionId,int machineId)
    {
        List<int> prDetail = await _appDbContext.ProductionOperations.Where(i => i.ProductionId == productionId && i.MachineId==machineId).Select(x => x.GecenSure).ToListAsync();
        int gecenSure = 0;
        int panelSayisi = prDetail.Count();

        ProductionOperationPanel panelDetail = new ProductionOperationPanel();
        foreach (var pr in prDetail)
        {
            gecenSure += pr;
        }

        panelDetail.ToplamGecenSure = gecenSure;
        panelDetail.ToplamPanelSayisi = prDetail.Count;
        return new ResponseModel(panelDetail);
    }



    
    public async Task<ResponseModel> GetFilterAsyncProductId(int productionId,string? Code)
    {
        return new ResponseModel(_mapper.Map<List<ProductionOperationsDtoQ>>(await _appDbContext.ProductionOperations
            .Where(i => i.ProductionId == productionId && i.QrCode.ToLower().Contains(Code==null ?"":Code.ToLower())).OrderByDescending(i => i.Id).Take(150).ToListAsync()));
    }


    public async Task<ResponseModel> GetAllQrCodeDetail(string code,int productionId, int machiheId)
    {
        string _feedLerData;

        if (productionId != 0)
        {
            _feedLerData = _appDbContext.ProductionOperations
                .Where(y => y.QrCode == code && y.ProductionId == productionId && y.MachineId == machiheId).FirstOrDefault()?.FeedlerData;

            if (_feedLerData != null)
            {
                List<int> dataS = JsonConvert.DeserializeObject<List<int>>(_feedLerData);
                var data = _appDbContext.SetupVerificationDetails.Include(t=> t.SetupVerification).ThenInclude(x => x.Production)
                                                            .Where(y => dataS.Contains(y.Id)).Select(y => new
                                                            {
                                                                Id = y.Id,
                                                                Material = y.Material,
                                                                PartyNumber = y.PartyNumber,
                                                                ProductionNo = y.SetupVerification.Production.OrderNo,
                                                                ProductionDef = y.SetupVerification.Production.UretimAdi
                                                            });
                return new ResponseModel(data);
            }

        }
        else
        {
            List<int> dataS = new();

            var _list = _appDbContext.ProductionOperations
                .Where(y => y.QrCode == code).ToList();

            foreach (var item in _list)
            {
                dataS.AddRange(JsonConvert.DeserializeObject<List<int>>(item.FeedlerData));
            }

            var data = _appDbContext.SetupVerificationDetails.Include(t => t.SetupVerification).ThenInclude(x => x.Production)
                                                       .Where(y => dataS.Contains(y.Id)).Select(y => new
                                                       {
                                                           Id = y.Id,
                                                           Material = y.Material,
                                                           PartyNumber = y.PartyNumber,
                                                           ProductionNo = y.SetupVerification.Production.OrderNo,
                                                           ProductionDef = y.SetupVerification.Production.UretimAdi
                                                       });
            return new ResponseModel(data);
        }
        return new ResponseModel(null);

    }

    public async Task<ResponseModel> GetMaterialtoQrcode(string materialandLotNo,int productionId)
    {
        var materialandLotNoIdList = await _appDbContext.SetupVerificationDetails
                                                        .Where(x => x.Material + "" + x.PartyNumber == materialandLotNo && x.SetupVerification.ProductionId == productionId)
                                                        .Select(x => x.Id)
                                                        .FirstOrDefaultAsync();


        var feedlerData = await _appDbContext.ProductionOperations.Where(y => y.ProductionId == productionId &&
                                                                           EF.Functions.JsonExists(y.FeedlerData, materialandLotNoIdList.ToString()))
                                                                  .Select(t => new
                                                                  {
                                                                      Id = t.Id,
                                                                      Qrcode = t.QrCode,
                                                                      MachineName = t.Machine.Name
                                                                  })
                                                                  .ToListAsync();

        return new ResponseModel(feedlerData);
    }

    public async Task<ResponseModel> GetProductions(string materialandLotNo)
    {
        var production = await _appDbContext.SetupVerificationDetails.Include(x => x.SetupVerification)
                                                                     .Where(y => y.Material + "" + y.PartyNumber == materialandLotNo)
                                                                     .GroupBy(cGrp => new { cGrp.SetupVerification.ProductionId, cGrp.SetupVerification.Production.OrderNo })

                                                                     .Select(x => x.Key)

                                                                     .ToListAsync();

        return new ResponseModel(production);
       
    }




    public async Task<ResponseModel> GetSetupVerificationDChange(int productionId, int machineId)  
    {
        var data = _appDbContext.SetupVerificationDChange.Include(t => t.OldPanel)
                                                       .Where(y => y.ProductionId == productionId && y.SetupVerificationDetailsOld.MachineId==machineId)
                                                       .Select(z=> new SetupVerificationDChangeDtoQ()
                                                       {
                                                           CreateDate = z.CreateDate,
                                                           NewPanelCode = z.NewPanel.QrCode,
                                                           OldPanelCode = z.OldPanel.QrCode,
                                                           OldBomKitCode = z.SetupVerificationDetailsOld.Material + "-" + z.SetupVerificationDetailsOld.PartyNumber + "-" + z.SetupVerificationDetailsOld.SiraNo,
                                                           NewBomKitCode = z.SetupVerificationDetailsNew.Material + "-" + z.SetupVerificationDetailsNew.PartyNumber + "-" + z.SetupVerificationDetailsNew.SiraNo,
                                                           OldPanelQty = z.OldPanelQty,
                                                           NewPanelQty = z.NewPanelQty
                                                       }
                                                           ).OrderByDescending(y=> y.CreateDate)
                                                       .ToList();

        return  new ResponseModel(data);
    }
    
    public async Task<ResponseModel> GetProductionTimeLog(int productionId)
    {
        var data = _appDbContext.ProductionLog
            .Where(y => y.ProductionId == productionId && y.ProductionProcess == ProductionProcess.ProductionProcessSecret)
            .ToList();

        return  new ResponseModel(data);
    }
    
    
    public async Task<ResponseModel> ChangeBomKitData(SetupVDChangeBomKitDto dto)
    {
        if (dto.RollerQuantity != null && dto.RollerQuantity>0)
        {
            var data = _appDbContext.SetupVerificationDetails.Where(x => x.Id == dto.Id).FirstOrDefault();
            if (data is not null)
            {
                
                var siraNo = _appDbContext.SetupVerificationDetails.Include(y => y.SetupVerification)
                    .Where(x => x.SetupVerification.ProductionId == dto.ProductionId && x.Material == data.Material &&
                                x.PartyNumber == data.PartyNumber && x.SetNo == data.SetNo && dto.MachineId==x.MachineId
                    ).OrderByDescending(x => x.Id).FirstOrDefault().SiraNo; 
                
                var ss = await _setupVerificationDetailService.Add(new SetupVerificationDetailDto()
                {
                    IsCompleted = false,
                    BomKitInfoId = data.BomKitInfoId,
                    SetNo = data.SetNo,
                    State = false,
                    Quantity = data.Quantity,
                    UsingQuantity = (data.RollerQuantity - data.UsingQuantity) < 0 ? (data.UsingQuantity - data.RollerQuantity) : 0,//eðer  chart - de ise   farkýný quantity olarak ekleriz deðilse 0 
                    RollerQuantity = dto.RollerQuantity,
                    Material = data.Material,
                    PartyNumber = dto.PartyNumber,
                    SiraNo = siraNo + 1,
                    MachineId = data.MachineId,
                    SetupVerificationId = data.SetupVerificationId
                });

                 data.ChangingBomKitInfoId = (int)ss.Data;
                 //data.FinishingQuantity = dto.FinishingQuantity;
                 //data.RollerQuantity = dto.RollerQuantity;
                
                _appDbContext.SetupVerificationDetails.Update(data);
                 return new ResponseModel((await _appDbContext.SaveChangesAsync()));
                //return new ResponseModel(Success:true);
            }
        }

      return new ResponseModel(Success:false);
    }
    
    public async Task<ResponseModel> Add(ProductionOperationsDtoC dto)
    {
       dto.QrCode = dto.QrCode.Trim();
       var newQrCode = dto.QrCode.Substring(1, dto.QrCode.Length - 1);
        
        var machineId = await _appDbContext.ProductionMachineMatch.Include(z=> z.Machine).AsNoTracking()
            .Where(x => x.State == true && x.ProductionId == dto.ProductionId && x.Machine.BarcodeReaderId == dto.QrCode.ToUpper().Substring(0, 1) )
            .Select(x=> x.MachineId) 
            .FirstOrDefaultAsync();
        
        if (_appDbContext.ProductionOperations.Any(x => x.QrCode == newQrCode &&
                                                                        x.ProductionId==dto.ProductionId && x.MachineId==machineId))
            return new ResponseModel(){ Success = false, Message = "Hata"};
    
        dto.QrCode = newQrCode;
        dto.MachineId = machineId;
        
        var getBomKitInfoId = await _appDbContext.SetupVerificationDetails.Include(y => y.SetupVerification).AsNoTracking()
            .Where(x => x.SetupVerification.ProductionId == dto.ProductionId && x.State == true && x.MachineId == machineId)
            .Select(x=> x.Id.ToString())
            .ToListAsync();

         var jsonData = JsonConvert.SerializeObject(getBomKitInfoId);
         dto.FeedlerData = jsonData;


        var endStartTime = await _appDbContext.ProductionTimeProcess.AsNoTracking().Where(x => x.ProductionId == dto.ProductionId &&
                                                                                               x.ProductionProcess == ProductionProcess.ProductionProcess &&         
                                                                                               (x.ProductionTimeStatus == ProductionTimeStatus.Resume || x.ProductionTimeStatus == ProductionTimeStatus.Start))
                                                                    .OrderByDescending(t => t.Id).FirstOrDefaultAsync();



        var oldProduction = await _appDbContext.ProductionOperations.AsNoTracking().Where(x => x.ProductionId == dto.ProductionId && x.MachineId == machineId)
                                               .OrderByDescending(t=>t.Id).FirstOrDefaultAsync();

        if (oldProduction != null)
        {
            if (oldProduction.CreateDate > endStartTime.CreateDate)
            {
                oldProduction.GecenSure = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)oldProduction.CreateDate).TotalSeconds;
            }
            else
            {
                oldProduction.GecenSure = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)endStartTime.CreateDate).TotalSeconds;
            }

            await _repository.UpdateAsync(oldProduction);
        }
      
            dto.GecenSure = 0;



        var entity = _mapper.Map<ProductionOperations>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(ProductionOperationsDtoC dto)
    {
        var entity = _mapper.Map<ProductionOperations>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }
    
    public async Task<ResponseModel> Delete(int id)
    {
        // Domain.Entities.RestCause station = await GetById(id);
        // await _repository.DeleteAsync(station);
        return  new ResponseModel();
    }

  
}