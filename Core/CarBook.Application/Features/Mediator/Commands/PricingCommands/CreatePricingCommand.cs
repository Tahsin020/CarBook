using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.PricingCommands;
public sealed class CreatePricingCommand : IRequest
{
    public string Name { get; set; }
}
