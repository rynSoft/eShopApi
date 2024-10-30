using eShop.Domain.Entities;

namespace eShop.Domain.Dtos;

public class QualityOperationDocumentDtoU
{
    public int QualityOperationId { get; set; }
    public byte[] Data { get; set; }
    public string DataType { get; set; }
    public string Description { get; set; }
}