namespace CarBook.Application.Features.CQRS.Results.CategoryResults;
public sealed class GetCategoryByIdQueryResult
{
    public int Id { get; set; }
    public string Name { get; set; }
}
