﻿namespace CarBook.Application.Features.Mediator.Results.BlogResults;
public sealed class GetAllBlogsWithAuthorQueryResult
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public string AuthorDescription { get; set; }
    public string AuthorImage { get; set; }
}
