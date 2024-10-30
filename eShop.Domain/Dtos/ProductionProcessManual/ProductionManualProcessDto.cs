using System;

namespace eShop.Domain.Dtos.ProductionProcessManual;

public class ProductionManualProcessDto
{
        public int? Id { get; set; }
        public int ProductionId { get; set; }
        public string? QrCode { get; set; }
}