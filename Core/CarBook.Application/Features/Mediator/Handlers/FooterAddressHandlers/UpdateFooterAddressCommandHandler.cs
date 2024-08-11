using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;
public sealed class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        FooterAddress footerAddress = await _repository.GetByIdAsync(request.Id);
        footerAddress.PhoneNumber = request.PhoneNumber;
        footerAddress.Address = request.Address;
        footerAddress.Email = request.Email;
        footerAddress.Description = request.Description;
        await _repository.UpdateAsync(footerAddress);
    }
}
