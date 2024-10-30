using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using eShop.Domain.Common;
using eShop.Domain.Dtos;
using eShop.Domain.Entities;
using eShop.Domain.Enum;
using eShop.Domain.Interfaces;
using eShop.Persistence;
using eShop.Service.Contract;

namespace eShop.Service.Implementation;

public class QualityOperationDocumentService : IQualityOperationDocumentService
{
    private readonly IRepository<QualityOperationDocument> _repository;
    private readonly IMapper _mapper;
    private readonly IAppDbContext _appDbContext;
    private readonly IQualityUserService _qualityUserService;
    public QualityOperationDocumentService(IRepository<QualityOperationDocument> repository, 
           IAppDbContext appDbContext, IQualityUserService qualityUserService,
           IMapper mapper)
    {
        _qualityUserService = qualityUserService;
        _repository = repository;
        _mapper = mapper;
        _appDbContext = appDbContext;
    }
    
    public async Task<ResponseModel> GetAll()
    {
        return  new  ResponseModel(_mapper.Map<List<LineDtoQ>>(await _appDbContext.QualityOperationDocument.ToListAsync()));
    }
    public async Task<ResponseModel> GetById(int id)
    {
        return new  ResponseModel(await _repository.GetAsync(id));
    }
    
    public async Task<ResponseModel> Add(QualityOperationDocumentDtoC dto)
    {  
        var entity = _mapper.Map<QualityOperationDocument>(dto);
        return await _repository.AddAsync(entity);
    }

    public async Task<ResponseModel> AddList(QualityOperationDocumentDtoC[] dto)
    {
       QualityOperation operation= _appDbContext.QualityOperation.Where(x => x.Id == dto[0].QualityOperationId).FirstOrDefault();
        if (operation != null)
        {

            using (TransactionScope ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {

                foreach (var item in dto)
                {
                    var entity = _mapper.Map<QualityOperationDocument>(item);
                    await _repository.AddAsync(entity);
                }
                operation.EndOperation = true;
                operation.EndOperationDate = DateTimeOffset.Now;
                _appDbContext.QualityOperation.Update(operation);
                await _appDbContext.SaveChangesAsync();
                await _qualityUserService.Add(new QualityUserDtoC()
                {
                    QualityProcess = QualityProcess.QualityCompleted,
                    Date = DateTimeOffset.Now,
                    QualityId = Convert.ToInt32(operation.QualityId),
                    Message = $" Kalite Operasyonu Tamamlandý . Operasyon Id: {dto[0].QualityOperationId}",
                    UserId = operation.AuthorizedPersonId,
                });
                ts.Complete();
            }
            return new ResponseModel("Success", true);
        }
        else
        {
            return new ResponseModel("Operasyon Bulunamadý", false);
        }
    }

    public async Task<ResponseModel> OperationDocument(QualityOperationDocumentDtoC[] dto)
    {
        QualityOperation operation = _appDbContext.QualityOperation.Where(x => x.Id == dto[0].QualityOperationId).FirstOrDefault();
        if (operation != null)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                foreach (var item in dto)
                {
                    var entity = _mapper.Map<QualityOperationDocument>(item);
                    await _repository.AddAsync(entity);
                }
                await _appDbContext.SaveChangesAsync();
                ts.Complete();
            }
            return new ResponseModel("Success", true);
        }
        else
        {
            return new ResponseModel("Operasyon Bulunamadý", false);
        }
    }



    public async Task<ResponseModel> Update(QualityOperationDocumentDtoC dto)
    {
        var entity = _mapper.Map<QualityOperationDocument>(dto);
        return new ResponseModel((await _repository.UpdateAsync(entity)));
    }

    public async Task<ResponseModel> Delete(int id)
    {
        QualityOperationDocument LineSingle = await _repository.GetSingleAsync(x => x.Id == id);
        return new ResponseModel((await _repository.DeleteAsync(LineSingle)));
    }
    public async Task<ResponseModel> OperationDocumentList(int id)
    {
        List<QualityOperationDocument> documentList = _appDbContext.QualityOperationDocument.Where(x=>x.QualityOperationId==id).ToList();
        return new ResponseModel(documentList);
    }

}