using System;
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

public class ShiftDefinitionService : IShiftDefinitionService
{
    private readonly IRepository<ShiftDefinition> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public ShiftDefinitionService(IRepository<ShiftDefinition> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<ShiftDefinitionDtoQ>>(await _appDbContext.ShiftDefinition.ToListAsync()));
    }

    public async Task<ResponseModel> GetAllFilter()
    {
        return new ResponseModel(_mapper.Map<List<ShiftDefinitionDtoQ>>(await _appDbContext.ShiftDefinition.Where(y => y.Active).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> Add(ShiftDefinitionDtoC dto)
    {

        var entity = _mapper.Map<ShiftDefinition>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(ShiftDefinitionDtoC dto)
    {
        var entity = _mapper.Map<ShiftDefinition>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        ShiftDefinition ShiftDefinitionSingle = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(ShiftDefinitionSingle)));
    }


}