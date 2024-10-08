﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.AuthorCommands;
public sealed class UpdateAuthorCommand : IRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
