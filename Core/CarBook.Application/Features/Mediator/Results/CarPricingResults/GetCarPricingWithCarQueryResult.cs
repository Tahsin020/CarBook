namespace CarBook.Application.Features.Mediator.Results.CarPricingResults;
public sealed class GetCarPricingWithCarQueryResult
{
    public int CarPricingId { get; set; }
    public int CarId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public string PricingName { get; set; }
    public decimal PricingAmount { get; set; }
}
