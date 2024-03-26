﻿using System;
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

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private IAppDbContext _appDbContext;
    
    private readonly IRepository<Domain.Entities.Product> _repository;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<ProductService> _logger;

    public ProductService(
        IAppDbContext appDbContext,
           IRepository<Domain.Entities.Product> repository,
           IHttpContextAccessor httpContextAccessor,
           ILogger<ProductService> logger,
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
        var production = await _appDbContext.Product.OrderByDescending(x=> x.Id).ToListAsync();
        return new ResponseModel(production);
    }
    public async Task<ResponseModel> GetAllProductId(int productionId)
    {
        var production = await _appDbContext.Product.Include(x => x.User).Where(x => x.ProductionId == productionId)
            .Select(x => new ProductDtoQ()
            {
                CreateDate = x.CreateDate,
                Id = x.Id,
                Qrcode = x.Qrcode,
                UserAdSoyAd = $"{x.User.Ad} {x.User.Soyad}"
            })
            .OrderBy(x => x.Id).ToListAsync();
        return new ResponseModel(production);
    }

    public async Task<ResponseModel> GetByQrCode(string code, int productionId)
    {
        if (await _appDbContext.Product.Where(x => x.ProductionId == productionId && x.Qrcode == code.Trim()).AnyAsync())
        {
            return new ResponseModel(_appDbContext.Product.Where(x => x.Qrcode == code.Trim()).FirstOrDefaultAsync().Result.Id);
        }
        else
            return new ResponseModel(0);
    }

    public async Task<ProductDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<ProductDtoQ>(entity);
    }
    public async Task<ResponseModel> Add(ProductDtoC dto)
    {
        _logger.LogWarning($"Product | Add : Start");
        if (!await _appDbContext.Product.AnyAsync(x => x.ProductionId == dto.ProductionId && x.Qrcode == dto.Qrcode))
        {
            var entity = _mapper.Map<Product>(dto);
            entity.UserId = _httpContextAccessor.HttpContext.GetCurrentUser();
            _logger.LogWarning($"Product | Add : End Succes");

            return await _repository.AddAsync(entity);
        }
        _logger.LogWarning($"Product | Add : End NotSuccess");
        return new ResponseModel { Success = false, Message = "Ürün Daha Önce Kaydetilmiş" };
    }

    public async Task<ResponseModel> Update(Product entity)
    {
        //var entity = _mapper.Map<Product>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        Product production = _appDbContext.Product.Where(x => x.Id == id).FirstOrDefault();
        
        _appDbContext.Product.Remove(production);
        await _appDbContext.SaveChangesAsync();
       
        return new ResponseModel { Success = false, Message = "Uretim Emri Bulunamadi" };
    }

    public async Task<ResponseModel> ProductNextOrder(string qrCode,int productionId)
    {
        var entity = await _appDbContext.Product.Where(y => y.ProductionId == productionId && y.Qrcode == qrCode).FirstOrDefaultAsync();
        entity.Order++;
       
        entity.NextWPRId = _appDbContext.WorkProcessRoute.Where(y => y.ProductionId == productionId && y.Order == entity.Order).FirstOrDefaultAsync().GetAwaiter().GetResult().Id;
        return new ResponseModel((await Update(entity)));
    }
}