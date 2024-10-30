using System;

namespace eShop.Domain.Dtos;

public class RestCauseElapsedDTO
{
    public string Name { get; set; }
    public double SumElapsedTime { get; set; }
}

public class ProductionHoursCount
{
    public int Hour { get; set; }
    public int ProductionCount { get; set; }
}

public class ProductionDatessCount
{
    public DateTimeOffset Dates { get; set; }
    public int ProductionCount { get; set; }
}