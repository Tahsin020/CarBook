using CarBook.Application.Features.Mediator.Commands.PricingCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers;
public sealed class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommand>
{
    private readonly IRepository<Pricing> _repository;

    public CreatePricingCommandHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
    {
        Pricing pricing = new()
        {
            Name = request.Name
        };
        await _repository.CreateAsync(pricing);
    }
}
