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

public class CameraService : ICameraService
{
    private readonly IRepository<Camera> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public CameraService(IRepository<Camera> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<CameraDtoQ>>(await _appDbContext.Camera.OrderBy(x=>x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    public async Task<ResponseModel> GetByLineId(int id)
    {
        return new ResponseModel(await _repository.GetWhereAsync(x=>x.Id ==id));
    }

    public async Task<ResponseModel> Add(CameraDtoC dto)
    {  
        var entity = _mapper.Map<Camera>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(CameraDtoC dto)
    {
        var entity = _mapper.Map<Camera>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        Camera machina = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(machina)));
    }


}