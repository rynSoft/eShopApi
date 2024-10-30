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

public class RestCauseService : IRestCauseService
{
    private readonly IRepository<RestCause> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public RestCauseService(IRepository<RestCause> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<RestCauseDtoQ>>(await _appDbContext.RestCause.OrderBy(x=> x.Name).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> Add(RestCauseDtoC dto)
    {  
        var entity = _mapper.Map<RestCause>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(RestCauseDtoC dto)
    {
        var entity = _mapper.Map<RestCause>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }
    public async Task<ResponseModel> Delete(int id)
    {
        RestCause restCause = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(restCause)));
    }


}