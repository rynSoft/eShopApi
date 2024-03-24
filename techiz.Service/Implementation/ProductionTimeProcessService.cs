using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Auth;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace techiz.Service.Implementation;

public class ProductionTimeProcessService : IProductionTimeProcessService
{
    private readonly IRepository<ProductionTimeProcess> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IProductionLogService _productionLogService;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IProductionUserService _productionUserService;
    private readonly IProductionMachineMatchService _productionMachineMatchService;
    public ProductionTimeProcessService(IRepository<ProductionTimeProcess> repository, 
           IAppDbContext appDbContext,
           IMapper mapper,
           IHttpContextAccessor httpContextAccessor,
           IProductionUserService productionUserService,
           IProductionMachineMatchService productionMachineMatchService,
           IProductionLogService productionLogService)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
        _productionUserService = productionUserService;
        _httpContextAccessor = httpContextAccessor;
        _productionMachineMatchService = productionMachineMatchService;
        _productionLogService = productionLogService;
        
    }
    
    public async Task<IEnumerable<ProductionTimeProcessDtoQ>> GetAllAsyncProductId(int id,ProductionProcess ps)
    {
        var process = _appDbContext.ProductionTimeProcess.Where(x => x.ProductionId == id
                                                                     && x.ProductionProcess == ps)
            .Select(x => new ProductionTimeProcessDtoQ()
                {
                    //UserAd =  x.User.ad   _appDbContext.User.Where(y=> y.Id == x.UserId).FirstOrDefault().Ad,
                    //UserSoyad =  _appDbContext.User.Where(y=> y.Id == x.UserId).FirstOrDefault().Soyad,
                    Date = x.StartDate,
                    Message=x.Definition,
                    ElapsedTime = x.ElapsedTime,
                    RestCause = x.RestCause.Name,
                    ProductionTimeStatus = EnumHelper<ProductionTimeStatus>.GetDisplayValue(x.ProductionTimeStatus),
                }
            ).OrderByDescending(x=> x.Date);
      
        return  process;
    }
    
    public async Task<ResponseModel> Start(ProductionTimeProcessDtoC dto)
    {   
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        await _productionLogService.Add(new ProductionLogDtoC()
        {
            Date = DateTimeOffset.Now,
            ProductionId = dto.ProductionId,
            Message = dto.Message,
            UserId = user
        });
        
        dto.ProductionTimeStatus = ProductionTimeStatus.Start;
        dto.UserId = user;
        var entity = _mapper.Map<ProductionTimeProcess>(dto);
        return await _repository.AddAsync(entity);
    }
    
    public async Task<ResponseModel> Pause(ProductionTimeProcessDtoC dto)
    {
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        var lastData = await _appDbContext.ProductionTimeProcess
                                                            .AsNoTracking()
                                                            .Where(x=> x.ProductionId == dto.ProductionId 
                                                                                         && x.ProductionProcess == dto.ProductionProcess)
                                                            .OrderBy(x => x.Id).LastOrDefaultAsync();
       
        if (lastData.ProductionTimeStatus == ProductionTimeStatus.Resume)
        {       

            lastData.EndDate = DateTimeOffset.UtcNow;
            await _repository.UpdateAsync(lastData);
        }
        
        if (dto.ProductionTimeStatus == ProductionTimeStatus.Pause)
        {
            lastData.ElapsedTime = DateTimeOffset.Now - lastData.StartDate;
            await _repository.UpdateAsync(lastData);
        }


        //// ProductionProcess
        //if (dto.ProductionProcess == ProductionProcess.ProductionProcess)
        //{
        //    var productionActiveList = _appDbContext.ProductionMachineMatch
        //                                            .Where(x => x.ProductionId == dto.ProductionId && x.State == true).AsNoTracking().ToList();
        //    foreach (var activeMachine in productionActiveList)
        //    {
        //        await _productionMachineMatchService.Update(new ProductionMachineMatchDtoU()
        //        {
        //            Id = activeMachine.Id,
        //            ProductionId = dto.ProductionId,
        //            State = activeMachine.State,
        //            StartDate = activeMachine.StartDate.Value,
        //            MachineId = activeMachine.MachineId,
        //            ElapsedTime = ( activeMachine.ElapsedTime ?? 0 ) + Convert.ToInt32(dto.ElapsedTime.TotalSeconds)
        //        });
        //    }
        //    await _appDbContext.SaveChangesAsync();
        //}
        
        dto.ProductionTimeStatus = ProductionTimeStatus.Pause;
     
        dto.UserId = user==null ? dto.UserId:user;
        var entity = _mapper.Map<ProductionTimeProcess>(dto);
        return await _repository.AddAsync(entity);
    }
    
    public async Task<ResponseModel> Resume(ProductionTimeProcessDtoC dto)
    {
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        var lastData = await _appDbContext.ProductionTimeProcess
                                                            .Where(x=> x.ProductionId == dto.ProductionId 
                                                                && !(x.ProductionTimeStatus == ProductionTimeStatus.Resume || x.ProductionTimeStatus == ProductionTimeStatus.Start)
                                                                && x.ProductionProcess == dto.ProductionProcess)
                                                            .OrderBy(x => x.Id).LastOrDefaultAsync();

        if (lastData.ProductionTimeStatus == ProductionTimeStatus.Pause)
        {
            lastData.EndDate = DateTime.Now;
            await _repository.UpdateAsync(lastData);
        }

        if (dto.ProductionTimeStatus == ProductionTimeStatus.Resume)
        {
            if (_appDbContext.RestCause.Where(x => x.Id == lastData.RestCauseId).AsNoTracking().FirstOrDefault().Hanging)
                lastData.ElapsedTime = TimeSpan.Zero;
            else
               lastData.ElapsedTime = DateTimeOffset.Now - lastData.StartDate;
            await _repository.UpdateAsync(lastData);
        }
     
        dto.ProductionTimeStatus = ProductionTimeStatus.Resume;
        dto.UserId = user;
        var entity = _mapper.Map<ProductionTimeProcess>(dto);
        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> Stop(ProductionTimeProcessDtoC dto)
    {
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        await _productionLogService.Add(new ProductionLogDtoC()
        {
            Date = DateTimeOffset.Now,
            ProductionId = dto.ProductionId,
            Message = dto.Message,
            UserId = (Guid)user,
        });

        var lastData = await _appDbContext.ProductionTimeProcess
                                                            .Where(x => x.ProductionId == dto.ProductionId
                                                            && x.ProductionProcess == dto.ProductionProcess)
                                                            .OrderBy(x => x.Id).LastOrDefaultAsync();

        lastData.EndDate = DateTimeOffset.Now;
        await _appDbContext.SaveChangesAsync();



        dto.ElapsedTime = DateTimeOffset.Now - lastData.StartDate;
        dto.ProductionTimeStatus = ProductionTimeStatus.Stop;
        dto.UserId = (Guid)user;
        var entity = _mapper.Map<ProductionTimeProcess>(dto);
        return await _repository.AddAsync(entity);


    }
    
        public async Task<ResponseModel> StopVirtual(ProductionTimeProcessDtoC dto)
    {
        var user = _httpContextAccessor.HttpContext.GetCurrentUser();
        await _productionLogService.Add(new ProductionLogDtoC()
        {  
            Date = DateTimeOffset.Now,
            ProductionId = dto.ProductionId,
            Message = dto.Message,
            UserId = (Guid)user,
        });



        
        return null;
    }
    
    public async Task<ResponseModel> Update(ProductionTimeProcess dto)
    {
        var entity =  _mapper.Map<ProductionTimeProcess>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }
}