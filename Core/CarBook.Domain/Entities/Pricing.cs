namespace CarBook.Domain.Entities;
public sealed class Pricing 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<CarPricing> CarPricings { get; set; }
}
