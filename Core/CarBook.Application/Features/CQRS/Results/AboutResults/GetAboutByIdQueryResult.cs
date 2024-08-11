namespace CarBook.Application.Features.CQRS.Results.AboutResults;
public sealed class GetAboutByIdQueryResult
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
