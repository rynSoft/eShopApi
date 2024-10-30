namespace eShop.Domain.Dtos;

public class RestCauseDtoQ : BaseSimpleModel
{
    public RestCauseDtoQ()
    {
    }

    public int Id { get; set; }
    public string Code { get; set; }
    public bool? Hanging { get; set; } = false;
    public bool UseOee { get; set; } = true;
    public string Name { get; set; }
}