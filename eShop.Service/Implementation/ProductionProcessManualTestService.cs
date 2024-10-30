using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using techiz.Domain;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Dtos.ProductionProcessManual;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class ProductionProcessManualTestService : IProductionProcessManualTestService
{
    private readonly IRepository<ProductionProcessManualTest> _repository;
    private readonly IMapper _mapper;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly IAppDbContext _appDbContext;
    
    public ProductionProcessManualTestService(IRepository<ProductionProcessManualTest> repository, 
           IAppDbContext appDbContext,
           IHttpContextAccessor httpContextAccessor,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }
    

    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> GetAllAsyncProductionProcessManualId(int productionId)
    {
        return new ResponseModel(_mapper.Map<List<ProductionProcessTestDto>>(await _appDbContext.ProductionProcessManualTest
            .Where(i => i.ProductionId == productionId ).OrderByDescending(i => i.TestBeginDate).Include(t => t.TestUser).Include(x=> x.ProductionOperations).ToListAsync()));
    
    }

  


    private async Task<int> FindFirstQrCodeId(int productionId,string qrCode,int? rangeCounts)
    {
        rangeCounts = rangeCounts ?? 10;
        List<string> lstSring = new();
        for (int i = 0; i < rangeCounts; i++)
        {
            var qrCodeNew = (Convert.ToDecimal(qrCode) - i).ToString().PadLeft(6, '0');
            lstSring.Add(qrCodeNew);
        }


        var rangeCount = await _appDbContext.ProductionOperations.Where(x => x.ProductionId == productionId &&
                                                                           lstSring.Contains((x.QrCode.Trim().Substring(x.QrCode.Trim().Length - 6))))
                                                                           .OrderByDescending(y=> y.QrCode.Trim().Substring(y.QrCode.Trim().Length - 6)).FirstOrDefaultAsync();

        
        return rangeCount.Id;
    }

    public async Task<ResponseModel> Add(ProductionProcessTestDto dto)
    {
        var findFirstQrCodeId = await FindFirstQrCodeId(dto.ProductionId, dto.QrCode.Trim().Substring(16, 6),dto.RangeCount);


        var entity = _mapper.Map<ProductionProcessManualTest>(dto);
        entity.ProductionOperationsId = findFirstQrCodeId;
        entity.QrCode = dto.QrCode.Trim().Substring(16, 6);
        entity.TestUserId = _httpContextAccessor.HttpContext.GetCurrentUser();

        if (!_appDbContext.ProductionProcessManualTest.Where(y=> y.QrCode == entity.QrCode).Any())
        return await _repository.AddAsync(entity);

        return new ResponseModel(Message : "Kayıt Bulunamadı");
    }

    public async Task<ResponseModel> ElapsedTimeCalculate(int productionId)
    {

        var testDataLabeling = _appDbContext.ProductionProcessManualTest.Where(y => y.ProductionId == productionId)
            .OrderByDescending(x => x.Id).FirstOrDefault();

        if (testDataLabeling != null)
        {
            testDataLabeling.TestElapsedTime = (int)(DateTimeOffset.Now - testDataLabeling.TestBeginDate).TotalSeconds;
            testDataLabeling.TestEndDate = DateTimeOffset.Now;

            await _repository.UpdateAsync(testDataLabeling);
        }

        return new ResponseModel(null);
    }
       

   
    public async Task<ResponseModel> Update(ProductionProcessTestDto dto)
    {
        var kontrol = await _appDbContext.ProductionProcessManualTest.Where(x => x.ProductionId == dto.ProductionId
                                                                                    && x.TestElapsedTime == null).FirstOrDefaultAsync();
        var entity = await _appDbContext.ProductionProcessManualTest.Where(x => x.Id == dto.Id).FirstOrDefaultAsync();


        if (kontrol is not null)
        {
            await ElapsedTimeCalculate(dto.ProductionId);
        }
        if (entity is not null)
        {

            if (dto.QrCode.Trim() != "Finish24061994")
            {

                entity.TestUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                entity.TestBeginDate = (DateTimeOffset)dto.TestBeginDate;
                return new ResponseModel((await _repository.UpdateAsync(entity)));
            }
            else
            {
                kontrol.TestUserId = _httpContextAccessor.HttpContext.GetCurrentUser();

                return new ResponseModel((await _repository.UpdateAsync(kontrol)));
            }
        }

        else
        {
            return new ResponseModel(Success: false);
        }
    }

}
