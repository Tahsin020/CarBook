using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;
public sealed class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        FooterAddress footerAddress = new()
        {
            Address = request.Address,
            Description = request.Description,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber
        };
        await _repository.CreateAsync(footerAddress);
    }
}
