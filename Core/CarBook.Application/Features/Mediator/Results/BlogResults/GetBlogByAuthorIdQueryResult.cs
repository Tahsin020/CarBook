namespace CarBook.Application.Features.Mediator.Results.BlogResults;
public sealed class GetBlogByAuthorIdQueryResult
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string AuthorDescription { get; set; }
    public string AuthorImage { get; set; }
}
