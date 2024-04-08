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

public class MaterialDecreaseHistoryService : IMaterialDecreaseHistoryService
{
    private readonly IMapper _mapper;
    private IAppDbContext _appDbContext;

    private readonly IRepository<Domain.Entities.MaterialDecreaseHistory> _repository;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<MaterialDecreaseHistoryService> _logger;

    public MaterialDecreaseHistoryService(
        IAppDbContext appDbContext,
           IRepository<Domain.Entities.MaterialDecreaseHistory> repository,
           IHttpContextAccessor httpContextAccessor,
           ILogger<MaterialDecreaseHistoryService> logger,
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
        var material = await _appDbContext.MaterialDecreaseHistory.OrderByDescending(x => x.Id).ToListAsync();
        return new ResponseModel(material);
    }
   
    public async Task<MaterialDecreaseHistoryDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x => x.Id == id);
        return _mapper.Map<MaterialDecreaseHistoryDtoQ>(entity);
    }
    public async Task<ResponseModel> Add(MaterialDecreaseHistoryDtoC dto)
    {


            var entity = _mapper.Map<MaterialDecreaseHistory>(dto);
            _logger.LogWarning($"Material | Add : End Succes");

            return await _repository.AddAsync(entity);
     
        _logger.LogWarning($"Material | Add : End NotSuccess");
        return new ResponseModel { Success = false, Message = "Ürün Daha Önce Kaydetilmiş" };
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
      
      
