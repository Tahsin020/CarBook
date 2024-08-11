﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.AuthorCommands;
public sealed class RemoveAuthorCommand : IRequest
{
    public int Id { get; set; }

    public RemoveAuthorCommand(int id)
    {
        Id = id;
    }
}
