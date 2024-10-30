using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using eShop.Domain;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

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