using System;

namespace eShop.Domain.Dtos;

public class LineDtoQ 
{
    public int? Id { get; set; }
    public int Number { get; set; }
    public bool Active { get; set; }
    public string Name { get; set; }
}