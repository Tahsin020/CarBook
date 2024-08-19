namespace CarBook.Application.Features.Mediator.Results.TagCloudResults;
public sealed class GetTagCloudByIdQueryResult
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int BlogId { get; set; }
}
