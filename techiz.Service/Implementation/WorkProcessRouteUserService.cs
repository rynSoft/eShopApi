using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using techiz.Domain.Common;
using techiz.Domain.Dtos;
using techiz.Domain.Entities;
using techiz.Domain.Enum;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using techiz.Service.Contract;

namespace techiz.Service.Implementation;

public class WorkProcessRouteUserService : IWorkProcessRouteUserService
{
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IProductionUserService _productionUserService;
    private readonly IRepository<Domain.Entities.WorkProcessRouteUser> _repository;

    public WorkProcessRouteUserService(
           IAppDbContext appDbContext,
           IRepository<Domain.Entities.WorkProcessRouteUser> repository,
           IMapper mapper,
           IProductionUserService productionUserService)
    {
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
        _productionUserService = productionUserService;
    }

    public async Task<ResponseModel> GetAll()
    {
        var entity = _appDbContext.WorkProcessRouteUser.ToList();
        return new ResponseModel(entity);
    }
    public async Task<WorkProcessRouteUserDtoQ> Get(int id)
    {
        var entity = await _repository.GetSingleAsync(x=>x.Id == id);
        return _mapper.Map<WorkProcessRouteUserDtoQ>(entity);
    }
    
    public async Task<IEnumerable<WorkProcessRouteUserDtoQ>> GetAllAsyncProductId(int id)
    {
        var result  = _appDbContext.WorkProcessRouteUser.Where(x=> x.WorkProcessRouteId == id)
            .Select(x=> new WorkProcessRouteUserDtoQ()
                {
                    Id = x.Id,             
                    UserId = x.UserId,
                }
            ).OrderBy(x=> x.Id);
            
        return result;
    }
    public async Task<ResponseModel> Add(WorkProcessRouteUserDtoC dto)
    {
        if (dto.WorkProcessRouteId is not null)
        {
            var routeUserList = _appDbContext.WorkProcessRouteUser.Where(x => x.WorkProcessRouteId == dto.WorkProcessRouteId).ToList();
            if(routeUserList.Where(x => x.UserId == dto.UserId).Any())
                return new ResponseModel(Success:false);

            var routeInfo = await _appDbContext.WorkProcessRoute.Include(y => y.Production).Where(z => z.Id == dto.WorkProcessRouteId).FirstOrDefaultAsync();

            await _productionUserService.Add(new ProductionUserDtoC()
            {
                Date = DateTimeOffset.Now,
                ProductionId = routeInfo.ProductionId,
                Message = $"Yeni Görev Atandı . Üretim Numarası {routeInfo.Production.OrderNo}",
                UserId = dto.UserId
            });

            var entity = _mapper.Map<WorkProcessRouteUser>(dto);
            return await _repository.AddAsync(entity);
        }
        return new ResponseModel();
    }
    public async Task<ResponseModel> Update(WorkProcessRouteUserDtoC data)
    {
        var entity = _mapper.Map<WorkProcessRouteUser>(data);
        return await _repository.UpdateAsync(entity);
    }

    public async Task<ResponseModel> Delete(int id)
    {
        WorkProcessRouteUser routeInfo = await _appDbContext.WorkProcessRouteUser.Where(x => x.Id == id).FirstOrDefaultAsync();
        //var st = await _productionUserService.Delete(routeInfo.WorkProcessRoute.ProductionId,(Guid)routeInfo.UserId);


        return new ResponseModel((await _repository.DeleteAsync(routeInfo)));
    }
}