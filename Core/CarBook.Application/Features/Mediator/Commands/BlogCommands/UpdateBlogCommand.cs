﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.BlogCommands;
public sealed class UpdateBlogCommand : IRequest
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; }
}
