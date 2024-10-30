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
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Enum;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;
namespace eShop.Service.Implementation;

public class MaterialDecreaseHistoryService : IMaterialDecreaseHistoryService
{
    private readonly IMapper _mapper;
    private IAppDbContext _appDbContext;

    private readonly IRepository<Domain.Entities.MaterialDecreaseHistory> _repository;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<MaterialDecreaseHistoryService> _logger;
    private readonly IMaterialService _materialService;

    public MaterialDecreaseHistoryService(
        IAppDbContext appDbContext,
           IRepository<Domain.Entities.MaterialDecreaseHistory> repository,
           IMaterialService materialService,
           IHttpContextAccessor httpContextAccessor,
           ILogger<MaterialDecreaseHistoryService> logger,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
        _materialService = materialService;
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }

    public async Task<ResponseModel> GetAll()
    {
        var material = await _appDbContext.MaterialDecreaseHistory.OrderByDescending(x => x.Id).ToListAsync();
        return new ResponseModel(material);
    }
   
    public async Task<MaterialDecreaseHistoryDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x => x.Id == id);
        return _mapper.Map<MaterialDecreaseHistoryDtoQ>(entity);
    }

    public async Task<ResponseModel> GetProductHistoryId(int productHistoryId)
    {
        var data = _mapper.Map<List<MaterialDecreaseHistoryDtoQ>>(await _appDbContext.MaterialDecreaseHistory.Include(y=> y.Material).Where(x => x.ProductHistoriesId == productHistoryId)
                              .OrderByDescending(x => x.Id).ToListAsync());
       
        return new ResponseModel(data);
    }


    public async Task<ResponseModel> Add(MaterialDecreaseHistoryDtoC dto)
    {
        var entity = _mapper.Map<MaterialDecreaseHistory>(dto);
        _logger.LogWarning($"MaterialDecreaseHistory | Add : {dto.MaterialId}");

        var materailCount = _appDbContext.MaterialDecreaseHistory.Where(x => x.MaterialId == dto.MaterialId).Count();
        var materailUpdate = _appDbContext.Material.FirstOrDefault(x => x.Id == dto.MaterialId);
        _logger.LogWarning($"MaterialDecreaseHistory | Add | materailCount : {materailCount}  materailUpdate : {materailUpdate}");
        materailUpdate.RemainQuantity = (materailCount * materailUpdate.DecreaseQuantity) + materailCount;
        _logger.LogWarning($"MaterialDecreaseHistory | Add | RemainQuantity : {materailUpdate.RemainQuantity} ");
        await _materialService.UpdateRemainQuantity(materailUpdate);

        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> Update(MaterialDecreaseHistoryDtoC dto)
    {
        var entity = _mapper.Map<MaterialDecreaseHistory>(dto);

        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        MaterialDecreaseHistory material = _appDbContext.MaterialDecreaseHistory.Where(x => x.Id == id).FirstOrDefault();

        _appDbContext.MaterialDecreaseHistory.Remove(material);
        await _appDbContext.SaveChangesAsync();

        return new ResponseModel { Success = false, Message = "Uretim Emri Bulunamadi" };
    }
}
      
      
