using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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

public class ProductionProcessManualService : IProductionProcessManualService
{
    private readonly IRepository<ProductionProcessManual> _repository;
    private readonly IMapper _mapper;
    private IHttpContextAccessor _httpContextAccessor;
    private readonly IAppDbContext _appDbContext;
    
    public ProductionProcessManualService(IRepository<ProductionProcessManual> repository, 
           IAppDbContext appDbContext,
           IHttpContextAccessor httpContextAccessor,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ProductionProcessManualDto>>(await _appDbContext.ProductionOperations.OrderBy(x=> x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> GetAllAsyncProductionProcessManualId(int productionId, ProductionProcess process, ProductionProcess previousProcess)
    {
        Expression<Func<ProductionProcessManual, bool>> filter = null;
        if (previousProcess == ProductionProcess.ProductionProcess)
        {
            filter = (x) => (x.ProductionId == productionId);
        }
        else if (previousProcess == ProductionProcess.ProductionProcessLabeling)
        {
            filter = (x) => ( x.ProductionId == productionId  && x.LabelingElapsedTime != null );
        }
        else if (previousProcess == ProductionProcess.ProductionProcessDisplayAssembly)
        {
            filter = (x) => (x.ProductionId == productionId && x.DisplayAssemblyElapsedTime != null);
        }
        else  if (previousProcess == ProductionProcess.ProductionProcessProgramming)
        {
            filter = (x) => (x.ProductionId == productionId && x.ProgrammingElapsedTime != null);
        } 
        else if (previousProcess == ProductionProcess.ProductionProcessDetachFromPanel)
        {
            filter = (x) => (x.ProductionId == productionId && x.DetachFromPanelElapsedTime != null );
        }

        object data = new();
        switch (process)
        {
            case ProductionProcess.ProductionProcessLabeling:
                data = new
                {
                    notRead = _mapper.Map<List<ProductionProcessLabelingDto>>(await _appDbContext.ProductionProcessManual
                                     .Include(t => t.LabelingUser)
                                     .Where(filter).OrderByDescending(i => i.LabelingEndDate).Take(20).ToListAsync()),
                    read = _mapper.Map<List<ProductionProcessLabelingDto>>(await _appDbContext.ProductionProcessManual
                                     .Include(t => t.LabelingUser)
                                     .Where(x=> x.LabelingBeginDate != null && x.ProductionId == productionId).OrderByDescending(i => i.LabelingEndDate).Take(20).ToListAsync())
                };
                break;
            case ProductionProcess.ProductionProcessDisplayAssembly:
                data = new
                {
                    notRead = _mapper.Map<List<ProductionProcessDisplayAssemblyDto>>(await _appDbContext.ProductionProcessManual
                                    .Include(t => t.DisplayUser)
                                    .Where(filter).OrderByDescending(i => i.DisplayAssemblyBeginDate).Take(20).ToListAsync()),
                    read = _mapper.Map<List<ProductionProcessDisplayAssemblyDto>>(await _appDbContext.ProductionProcessManual
                                    .Include(t => t.DisplayUser)
                                    .Where(x => x.DisplayAssemblyBeginDate != null && x.ProductionId == productionId).OrderByDescending(i => i.DisplayAssemblyEndDate).Take(20).ToListAsync())
                };
                break;
            case ProductionProcess.ProductionProcessProgramming:
                data = new
                {
                    notRead = _mapper.Map<List<ProductionProcessProgrammingDto>>(await _appDbContext.ProductionProcessManual
                                   .Include(t => t.ProgrammingUser)
                                   .Where(filter).OrderByDescending(i => i.ProgrammingBeginDate).Take(20).ToListAsync()),
                    read = _mapper.Map<List<ProductionProcessProgrammingDto>>(await _appDbContext.ProductionProcessManual
                                   .Include(t => t.ProgrammingUser)
                                   .Where(x => x.ProgrammingBeginDate != null && x.ProductionId == productionId).OrderByDescending(i => i.ProgrammingEndDate).Take(20).ToListAsync())
                };
                break;
            case ProductionProcess.ProductionProcessDetachFromPanel:
                data = new
                {
                    notRead = _mapper.Map<List<ProductionProcessDetachFromPanelDto>>(await _appDbContext.ProductionProcessManual
                   .Include(t => t.DetachFromPanelUser)
                   .Where(filter).OrderByDescending(i => i.DetachFromPanelBeginDate).Take(20).ToListAsync()),
                    read = _mapper.Map<List<ProductionProcessDetachFromPanelDto>>(await _appDbContext.ProductionProcessManual
                   .Include(t => t.DetachFromPanelUser)
                   .Where(x => x.DetachFromPanelBeginDate != null && x.ProductionId == productionId).OrderByDescending(i => i.DetachFromPanelEndDate).Take(20).ToListAsync())
                };
                break;
        }
        return new ResponseModel(data);
    }

    public async Task<ResponseModel> GetByQrCode(string code, int productionId, ProductionProcess process, ProductionProcess previousProcess)
    {

        Expression<Func<ProductionProcessManual, bool>> filter = null;

        if (previousProcess == ProductionProcess.ProductionProcess)
        {
            filter = (x) => (x.ProductionId == productionId);
        }
        else if (previousProcess == ProductionProcess.ProductionProcessLabeling)
        {
            filter = (x) => (x.ProductionId == productionId && x.LabelingElapsedTime != null);
        }
        else if (previousProcess == ProductionProcess.ProductionProcessDisplayAssembly)
        {
            filter = (x) => (x.ProductionId == productionId && x.DisplayAssemblyElapsedTime != null);
        }
        else if (previousProcess == ProductionProcess.ProductionProcessProgramming)
        {
            filter = (x) => (x.ProductionId == productionId && x.ProgrammingElapsedTime != null);
        }
        else if (previousProcess == ProductionProcess.ProductionProcessDetachFromPanel)
        {
            filter = (x) => (x.ProductionId == productionId && x.DetachFromPanelElapsedTime != null);
        }


        if (process == ProductionProcess.ProductionProcessLabeling && await _appDbContext.ProductionProcessManual
                                                                                   .Where(filter)
                                                                                   .Where(x => x.QrCode == code.Trim() && x.LabelingElapsedTime == null).AnyAsync())
        {
            return new ResponseModel(_appDbContext.ProductionProcessManual
                                                                                   .Where(filter)
                                                                                   .Where(x => x.QrCode == code.Trim() && x.LabelingElapsedTime == null).FirstOrDefaultAsync().Result.Id);
        }
        else if (process == ProductionProcess.ProductionProcessDisplayAssembly && await _appDbContext.ProductionProcessManual
                                                                                   .Where(filter)
                                                                                   .Where(x => x.QrCode == code.Trim() && x.DisplayAssemblyElapsedTime == null).AnyAsync())
        {
            return new ResponseModel(_appDbContext.ProductionProcessManual
                                                                                   .Where(filter)
                                                                                   .Where(x => x.QrCode == code.Trim() && x.DisplayAssemblyElapsedTime == null).FirstOrDefaultAsync().Result.Id);
        }
        else if (process == ProductionProcess.ProductionProcessProgramming && await _appDbContext.ProductionProcessManual
                                                                                   .Where(filter)
                                                                                   .Where(x => x.QrCode == code.Trim() && x.ProgrammingElapsedTime == null).AnyAsync())
        {
            return new ResponseModel(_appDbContext.ProductionProcessManual
                                                                                   .Where(filter)
                                                                                   .Where(x =>  x.QrCode == code.Trim() && x.ProgrammingElapsedTime == null).FirstOrDefaultAsync().Result.Id);
        }
        else if (process == ProductionProcess.ProductionProcessDetachFromPanel && await _appDbContext.ProductionProcessManual
                                                                                    .Where(filter)
                                                                                   .Where(x => x.QrCode == code.Trim() && x.DetachFromPanelElapsedTime == null).AnyAsync())
        {
            return new ResponseModel(_appDbContext.ProductionProcessManual
                                                                                   .Where(filter)
                                                                                   .Where(x => x.QrCode == code.Trim() && x.DetachFromPanelElapsedTime == null).FirstOrDefaultAsync().Result.Id);
        }
        else

            return new ResponseModel(0);
    }
    
    public async Task<ResponseModel> Add(ProductionManualProcessDto dto)
    {  
        if (!await _appDbContext.ProductionProcessManual.Where(z=> z.QrCode == dto.QrCode && dto.ProductionId == z.ProductionId).AnyAsync())
        {
            var entity = _mapper.Map<ProductionProcessManual>(dto);
            return await _repository.AddAsync(entity);
        }
        return null;
    }
    
    public async Task<ResponseModel> ElapsedTimeCalculate(ProductionProcess process,int productionId,ProductionProcessManual ps)
    {

        switch (process)
        {
            case ProductionProcess.ProductionProcessLabeling:
           
                if (ps != null)
                {
                    var endStartTime = await _appDbContext.ProductionTimeProcess.AsNoTracking().Where(x => x.ProductionId == productionId &&
                                                                                       x.ProductionProcess == ProductionProcess.ProductionProcessLabeling &&
                                                                                       (x.ProductionTimeStatus == ProductionTimeStatus.Resume || x.ProductionTimeStatus == ProductionTimeStatus.Start))
                                                                                 .OrderByDescending(t => t.Id).FirstOrDefaultAsync();


                    if (ps.LabelingBeginDate > endStartTime.CreateDate)
                    {
                        ps.LabelingElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)ps.LabelingBeginDate).TotalSeconds;
                    }
                    else
                    {
                        ps.LabelingElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)endStartTime.CreateDate).TotalSeconds;
                    }

                    ps.LabelingEndDate = DateTimeOffset.Now;

                    await _repository.UpdateAsync(ps);
                }
                break;
            case ProductionProcess.ProductionProcessDisplayAssembly:
                if (ps != null)
                {
                    var endStartTime = await _appDbContext.ProductionTimeProcess.AsNoTracking().Where(x => x.ProductionId == productionId &&
                                                                                       x.ProductionProcess == ProductionProcess.ProductionProcessDisplayAssembly &&
                                                                                       (x.ProductionTimeStatus == ProductionTimeStatus.Resume || x.ProductionTimeStatus == ProductionTimeStatus.Start))
                                                                                 .OrderByDescending(t => t.Id).FirstOrDefaultAsync();


                    if (ps.DisplayAssemblyBeginDate > endStartTime.CreateDate)
                    {
                        ps.DisplayAssemblyElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)ps.DisplayAssemblyBeginDate).TotalSeconds;
                    }
                    else
                    {
                        ps.DisplayAssemblyElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)endStartTime.CreateDate).TotalSeconds;
                    }

                    ps.DisplayAssemblyEndDate = DateTimeOffset.Now;

                    await _repository.UpdateAsync(ps);
                }
                break;
 
            case ProductionProcess.ProductionProcessProgramming:
                if (ps != null)
                {
                    var endStartTime = await _appDbContext.ProductionTimeProcess.AsNoTracking().Where(x => x.ProductionId == productionId &&
                                                                   x.ProductionProcess == ProductionProcess.ProductionProcessProgramming &&
                                                                   (x.ProductionTimeStatus == ProductionTimeStatus.Resume || x.ProductionTimeStatus == ProductionTimeStatus.Start))
                                                             .OrderByDescending(t => t.Id).FirstOrDefaultAsync();


                    if (ps.ProgrammingBeginDate > endStartTime.CreateDate)
                    {
                        ps.ProgrammingElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)ps.ProgrammingBeginDate).TotalSeconds;
                    }
                    else
                    {
                        ps.ProgrammingElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)endStartTime.CreateDate).TotalSeconds;
                    }

                    ps.ProgrammingEndDate = DateTimeOffset.Now;
                
                    await _repository.UpdateAsync(ps);
                }
                break;
            case ProductionProcess.ProductionProcessDetachFromPanel:
                if (ps != null)
                {
                    var endStartTime = await _appDbContext.ProductionTimeProcess.AsNoTracking().Where(x => x.ProductionId == productionId &&
                                                                  x.ProductionProcess == ProductionProcess.ProductionProcessDetachFromPanel &&
                                                                  (x.ProductionTimeStatus == ProductionTimeStatus.Resume || x.ProductionTimeStatus == ProductionTimeStatus.Start))
                                                            .OrderByDescending(t => t.Id).FirstOrDefaultAsync();


                    if (ps.DetachFromPanelBeginDate > endStartTime.CreateDate)
                    {
                        ps.DetachFromPanelElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)ps.DetachFromPanelBeginDate).TotalSeconds;
                    }
                    else
                    {
                        ps.DetachFromPanelElapsedTime = (int)DateTimeOffset.Now.Subtract((DateTimeOffset)endStartTime.CreateDate).TotalSeconds;
                    }

                    ps.DetachFromPanelEndDate = DateTimeOffset.Now;
                
                    await _repository.UpdateAsync(ps);
                }
                break;
        }
       
        return new ResponseModel(null);
    }
    
    public async Task<ResponseModel> LabelingUpdate(ProductionProcessLabelingDto dto)
    {
        var kontrol = await _appDbContext.ProductionProcessManual.Where(x => x.ProductionId == dto.ProductionId && x.LabelingBeginDate != null  &&
                                                                             x.LabelingElapsedTime == null).FirstOrDefaultAsync();
        var entity = await _appDbContext.ProductionProcessManual.Where(x => x.Id == dto.Id).FirstOrDefaultAsync();
        if (kontrol is not null)
        {
            await ElapsedTimeCalculate(ProductionProcess.ProductionProcessLabeling, dto.ProductionId, kontrol);
        }
        if (entity is not null)
        {
            if (dto.QrCode.Trim() != "Finish24061994")
            {
                entity.LabelingUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                entity.LabelingBeginDate = DateTimeOffset.Now;
                return new ResponseModel((await _repository.UpdateAsync(entity)));
            }
            else
            {
                entity.LabelingUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                entity.LabelingBeginDate = DateTimeOffset.Now;
                return new ResponseModel((await _repository.UpdateAsync(kontrol)));
            }
        }
        else
        {
            return new ResponseModel(Success: false);
        }
    }
    public async Task<ResponseModel> DisplayAssemblyUpdate(ProductionProcessDisplayAssemblyDto dto)
    {
        var kontrol = await _appDbContext.ProductionProcessManual.Where(x => x.ProductionId == dto.ProductionId && x.DisplayAssemblyBeginDate != null &&
                                                                                               x.DisplayAssemblyElapsedTime == null).FirstOrDefaultAsync();
        var entity = await _appDbContext.ProductionProcessManual.Where(x => x.Id == dto.Id).FirstOrDefaultAsync();
        if (kontrol is not null)
        {
            await ElapsedTimeCalculate(ProductionProcess.ProductionProcessDisplayAssembly, dto.ProductionId, kontrol);
        }
        if (entity is not null)
        {
            if (dto.QrCode.Trim() != "Finish24061994")
            {
                entity.DisplayUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                entity.DisplayAssemblyBeginDate = DateTimeOffset.Now;
                entity.DisplayAssemblyLotNo = dto.DisplayAssemblyLotNo;
                return new ResponseModel((await _repository.UpdateAsync(entity)));
            }
            else
            {
                kontrol.DisplayUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                kontrol.DisplayAssemblyBeginDate = DateTimeOffset.Now;
                kontrol.DisplayAssemblyLotNo = dto.DisplayAssemblyLotNo;
                return new ResponseModel((await _repository.UpdateAsync(kontrol)));
            }
        }
        else
        {
            return new ResponseModel(Success: false);
        }
    }

    public async Task<ResponseModel> ProgrammingUpdate(ProductionProcessProgrammingDto dto)
    {
        var kontrol = await _appDbContext.ProductionProcessManual.Where(x => x.ProductionId == dto.ProductionId && x.ProgrammingBeginDate != null &&
                                                                                           x.ProgrammingElapsedTime == null).FirstOrDefaultAsync();
        var entity = await _appDbContext.ProductionProcessManual.Where(x => x.Id == dto.Id).FirstOrDefaultAsync();
        if (kontrol is not null)
        {
            await ElapsedTimeCalculate(ProductionProcess.ProductionProcessProgramming, dto.ProductionId, kontrol);
        }
        if (entity is not null)
        {
            if (dto.QrCode.Trim() != "Finish24061994")
            {

                entity.ProgrammingUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                entity.ProgrammingBeginDate = DateTimeOffset.Now;
                return new ResponseModel((await _repository.UpdateAsync(entity)));
            }
            else
            {
                kontrol.ProgrammingUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                kontrol.ProgrammingBeginDate = DateTimeOffset.Now;
                return new ResponseModel((await _repository.UpdateAsync(kontrol)));
            }
        }
        else
        {
            return new ResponseModel(Success: false);
        }

    }

    public async Task<ResponseModel> DetachFromPanelUpdate(ProductionProcessDetachFromPanelDto dto)
    {
        var kontrol = await _appDbContext.ProductionProcessManual.Where(x => x.ProductionId == dto.ProductionId && x.DetachFromPanelBeginDate != null &&
                                                                             x.DetachFromPanelElapsedTime == null).FirstOrDefaultAsync();

        var entity = await _appDbContext.ProductionProcessManual.Where(x => x.Id == dto.Id).FirstOrDefaultAsync();


        if (kontrol is not null)
        {
            await ElapsedTimeCalculate(ProductionProcess.ProductionProcessDetachFromPanel, dto.ProductionId, kontrol);
        }

        if (entity is not null)
        {
            if (dto.QrCode.Trim() != "Finish24061994")
            {
                entity.DetachFromPanelUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                entity.DetachFromPanelBeginDate = DateTimeOffset.Now;
                return new ResponseModel((await _repository.UpdateAsync(entity)));
            }
            else
            {
                kontrol.DetachFromPanelUserId = _httpContextAccessor.HttpContext.GetCurrentUser();
                return new ResponseModel((await _repository.UpdateAsync(kontrol)));
            }
        }
        else
        {
            return new ResponseModel(Success: false);
        }
    }
}
