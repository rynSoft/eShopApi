using System;
using eShop.Domain.Entities;

namespace eShop.Domain.Dtos;

public class ScrapInfoDtoQ
{
    public int? Id { get; set; }
    public string Explanation { get; set; }
    public string VirtualName { get; set; }
    public int WorkProcessRouteId { get; set; }
    public int? MaterialId { get; set; }
    public int Quantity { get; set; }
}