using System;
using techiz.Domain.Enum;

namespace techiz.Domain.Dtos;

public class CameraDtoC
{
    public int? Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string? IpAdress { get; set; }
    public int? Port { get; set; }
    public bool Active { get; set; }
}