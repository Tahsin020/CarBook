namespace CarBook.Application.Features.Mediator.Results.BlogResults;
public sealed class GetBlogQueryResult
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; }
}
