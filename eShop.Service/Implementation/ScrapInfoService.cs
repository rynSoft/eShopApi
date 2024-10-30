using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class ScrapInfoService : IScrapInfoService
{
    private readonly IRepository<ScrapInfo> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ScrapInfoService(IRepository<ScrapInfo> repository,
           IAppDbContext appDbContext,
           IMapper mapper,
           IHttpContextAccessor httpContextAccessor)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<ResponseModel> GetAll()
    {
       return new ResponseModel(_mapper.Map<List<ScrapInfoDtoQ>>(await _appDbContext.ScrapInfo.ToListAsync()));
    }

    public async Task<ResponseModel> GetAllFilter()
    {
        return new ResponseModel(_mapper.Map<List<ScrapInfoDtoQ>>(await _appDbContext.ScrapInfo.Where(y=> y.Active).ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> Add(ScrapInfoDtoC dto)
    {  
        var entity = _mapper.Map<ScrapInfo>(dto);
        return await _repository.AddAsync(entity);
    }
    public async Task<ResponseModel> Update(ScrapInfoDtoC dto)
    {
        var entity = _mapper.Map<ScrapInfo>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        ScrapInfo ScrapInfoSingle = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(ScrapInfoSingle)));
    }


}