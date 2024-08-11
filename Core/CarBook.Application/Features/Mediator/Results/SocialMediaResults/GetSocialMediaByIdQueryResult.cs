﻿namespace CarBook.Application.Features.Mediator.Results.SocialMediaResults;
public sealed class GetSocialMediaByIdQueryResult
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
