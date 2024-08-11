namespace CarBook.Application.Features.CQRS.Results.BrandResults;
public sealed class GetBrandByIdQueryResult
{
    public int Id { get; set; }
    public string Name { get; set; }
}
