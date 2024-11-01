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

public class ProductService : IProductService
{
    private readonly IRepository<Product> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public ProductService(IRepository<Product> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
       return  new  ResponseModel(_mapper.Map<List<ProductDtoQ>>(await _appDbContext.Product.OrderBy(x=>x.Id).ToListAsync()));

    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    public async Task<ResponseModel> GetByLineId(int id)
    {
        return new ResponseModel(await _repository.GetWhereAsync(x=>x.Id ==id));
    }

    public async Task<ResponseModel> Add(ProductDtoC dto)
    {  
        var entity = _mapper.Map<Product>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(ProductDtoC dto)
    {
        var entity = _mapper.Map<Product>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        Product product = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(product)));
    }


}