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

public class MachineService : IMachineService
{
    private readonly IRepository<Machine> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    
    public MachineService(IRepository<Machine> repository, 
           IAppDbContext appDbContext,
           IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<MachineDtoQ>>(await _appDbContext.Machine.Include(x=> x.Line).OrderBy(x=>x.Id).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    public async Task<ResponseModel> GetByLineId(int id)
    {
        return new ResponseModel(await _repository.GetWhereAsync(x=>x.LineId==id));
    }

    public async Task<ResponseModel> Add(MachineDtoC dto)
    {  
        var entity = _mapper.Map<Machine>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(MachineDtoC dto)
    {
        var entity = _mapper.Map<Machine>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        Machine machina = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(machina)));
    }


}