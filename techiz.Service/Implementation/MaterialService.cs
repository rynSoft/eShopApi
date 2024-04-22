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
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;
namespace techiz.Service.Implementation;

public class MaterialService : IMaterialService
{
    private readonly IMapper _mapper;
    private IAppDbContext _appDbContext;

    private readonly IRepository<Domain.Entities.Material> _repository;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<MaterialService> _logger;

    public MaterialService(
        IAppDbContext appDbContext,
           IRepository<Domain.Entities.Material> repository,
           IHttpContextAccessor httpContextAccessor,
           ILogger<MaterialService> logger,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }

    public async Task<ResponseModel> GetAll()
    {
        var material = await _appDbContext.Material.OrderByDescending(x => x.Id).ToListAsync();
        return new ResponseModel(material);
    }
    public async Task<ResponseModel> GetAllMaterialId(int productionId)
    {
        return new ResponseModel(_mapper.Map<List<MaterialDtoQ>>(await _appDbContext.Material.Where(x => x.ProductionId == productionId).OrderByDescending(x => x.Id).ToListAsync()));

    }
    public async Task<ResponseModel> GetByQrCodeMaterial(int productionId, string code,int workProcessRouteId)
    {
        if (!await _appDbContext.Material.Where(x => x.ProductionId == productionId && x.Code == code).AnyAsync())
        {
            return new ResponseModel() { Success = false, Message = $"Bu iş sürecinde {code}'lu ürün bulunamadı" };
        }
        else
        {
            return new ResponseModel() { Success = true, Data = _appDbContext.Material.Where(x => x.ProductionId == productionId && x.Code == code).FirstOrDefaultAsync().Result?.Id, Message = $"{code}'lu ürün bulundu" };
        }
    }

    public async Task<MaterialDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x => x.Id == id);
        return _mapper.Map<MaterialDtoQ>(entity);
    }
    public async Task<ResponseModel> Add(MaterialDtoC dto)
    {
        _logger.LogWarning($"Material | Add : Start {dto.Code}");
        if (!await _appDbContext.Material.AnyAsync(x => x.ProductionId == dto.ProductionId && x.Code == dto.Code))
        {
            var entity = _mapper.Map<Material>(dto);
            _logger.LogWarning($"Material | Add : End Succes");

            return await _repository.AddAsync(entity);
        }
        _logger.LogWarning($"Material | Add : End NotSuccess");
        return new ResponseModel { Success = false, Message = "Ürün Daha Önce Kaydetilmiş" };
    }

    public async Task<ResponseModel> Update(MaterialDtoC dto)
    {
        var entity = _mapper.Map<Material>(dto);

        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> UpdateRemainQuantity(Material entity)
    {
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }


    public async Task<ResponseModel> Delete(int id)
    {
        Material material = _appDbContext.Material.Where(x => x.Id == id).FirstOrDefault();

        _appDbContext.Material.Remove(material);
        await _appDbContext.SaveChangesAsync();

        return new ResponseModel { Success = false, Message = "Uretim Emri Bulunamadi" };
    }



}
      
      
