using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class ProductionMachineMatchService : IProductionMachineMatchService
{
    private readonly IRepository<ProductionMachineMatch> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public ProductionMachineMatchService(IRepository<ProductionMachineMatch> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ProductionMachineMatchDtoQ>>(await _appDbContext.ProductionMachineMatch.OrderBy(x=>x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }

    public async Task<ResponseModel> Add(ProductionMachineMatchDtoC dto)
    {  
        var entity = _mapper.Map<ProductionMachineMatch>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(ProductionMachineMatchDtoU dto)
    {
        var data = _appDbContext.ProductionMachineMatch.Where(y => y.Id == dto.Id).FirstOrDefault();
      
        if (data.StartDate != null)
        dto.StartDate = data.StartDate.Value.Year > 1 ? data.StartDate.Value : dto.StartDate;
        dto.ElapsedTime = dto.ElapsedTime > 0 ? dto.ElapsedTime : data.ElapsedTime;
        
        
        var entity = _mapper.Map<ProductionMachineMatch>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        ProductionMachineMatch machina = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(machina)));
    }


}