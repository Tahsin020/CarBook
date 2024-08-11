﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
public sealed class CreateFooterAddressCommand : IRequest
{
    public string Description { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}
