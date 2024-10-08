﻿namespace CarBook.Application.Features.CQRS.Results.BannerResults;
public sealed class GetBannerByIdQueryResult
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string VideoDescription { get; set; }
    public string VideoUrl { get; set; }
}
