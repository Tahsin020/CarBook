using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.PricingCommands;
public sealed class RemovePricingCommand : IRequest
{
    public int Id { get; set; }
    public RemovePricingCommand(int id)
    {
        Id = id;
    }
}
