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

public class SetupVerificationService : ISetupVerificationService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IRepository<Domain.Entities.SetupVerification> _repository;
    private readonly ILogger<SetupVerificationService> _logger;
    
    public SetupVerificationService(
           IAppDbContext appDbContext,
           IRepository<Domain.Entities.SetupVerification> repository, 
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
        List<SetupVerificationDto> SetupVerification = _mapper.Map<List<Domain.Entities.SetupVerification>,List<SetupVerificationDto>>(_appDbContext.SetupVerification
                                                                                      .Include(x=> x.Production).OrderByDescending(x=> x.Id).ToList());
        return new ResponseModel(SetupVerification);
    }
            // IEnumerable<SetupVerificationDtoQ> SetupVerification = _mapper.Map<IEnumerable<Domain.Entities.SetupVerification>,IEnumerable<SetupVerificationDtoQ>>
                      //     (await _repository.GetAllAsync(x=>x.ProductionId == id ,include: y=> y.Include(a=> a.WareHouse) ));
    public async Task<IEnumerable<SetupVerificationDto>> GetAllAsyncProductId(int id)
    {
        
       var result  = _appDbContext.SetupVerification
           .Where(x=> x.ProductionId == id)
           .Select(x=> new SetupVerificationDto()
        {
            Id = x.Id,

            ProductionId = x.ProductionId,
          
        }
       ).OrderBy(x=> x.Id);
            
        return result;
    }
    public async Task<SetupVerificationDto> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<SetupVerificationDto>(entity);
    }
    
    public async Task<ResponseModel> Add(SetupVerificationDto dto)
    {  
        var entity = _mapper.Map<SetupVerification>(dto);
        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> Update(SetupVerificationDto dto)
    {
        var entity = _mapper.Map<SetupVerification>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }
}