using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class ProductionOperationsTimeLogService : IProductionOperationsTimeLogService
{
    private readonly IRepository<ProductionOperationsTimeLog> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public ProductionOperationsTimeLogService(IRepository<ProductionOperationsTimeLog> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll(int productionId)
    {
        return  new  ResponseModel(_mapper.Map<List<ProductionOperationsTimeLogDtoQ>>(await _appDbContext.ProductionOperationsTimeLog
            .Include(x=> x.ProductionOperations)
            .Where(x=> x.ProductionId == productionId)
            .OrderBy(x=> x.Id).ToListAsync()));
    }

    public async Task<ResponseModel> GetAllMachine(int productionId, int machineId)
    {
        return new ResponseModel(_mapper.Map<List<ProductionOperationsTimeLogDtoQ>>(await _appDbContext.ProductionOperationsTimeLog
            .Include(x => x.ProductionOperations)
            .Where(x => x.ProductionId == productionId && x.ProductionOperations.MachineId==machineId)
            .OrderBy(x => x.Id).ToListAsync()));
    }


    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> Add(ProductionOperationsTimeLogDtoC dto)
    {
        var productionOpId = _appDbContext.ProductionOperations.Where(x => x.ProductionId == dto.ProductionId)
            .OrderByDescending(x=> x.Id).FirstOrDefault().Id;
        
        dto.ProductionOperationsId = productionOpId; 
        var entity = _mapper.Map<ProductionOperationsTimeLog>(dto);
        return await _repository.AddAsync(entity);
    }
 


}