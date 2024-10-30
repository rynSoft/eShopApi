using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using techiz.Domain;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class WorkCentreService : IWorkCentreService
{
    private readonly IMapper _mapper;
    private IAppDbContext appDbContext;
    private readonly IRepository<Domain.Entities.WorkCentre> _repository;

    public WorkCentreService(
        IAppDbContext appDbContext,
           IRepository<Domain.Entities.WorkCentre> repository,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        this.appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        var data = appDbContext.WorkCentre.ToList();
        return new ResponseModel(data);
    }
   
    public async Task<ResponseModel> Add(WorkCentreDtoC dto)
    {  
        var entity = _mapper.Map<WorkCentre>(dto);
        return await _repository.AddAsync(entity);
    }
    
    public async Task<WorkCentre> GetWorkCentre(int id)
    {
        return await _repository.GetSingleAsync(x=> x.Id == id);
    }
}