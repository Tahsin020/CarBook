﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.LocationCommands;
public sealed class CreateLocationCommand : IRequest
{
    public string Name { get; set; }
}
