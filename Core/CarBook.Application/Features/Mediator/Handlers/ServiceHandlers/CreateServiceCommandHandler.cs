using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers;
public sealed class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
{
    private readonly IRepository<Service> _repository;

    public CreateServiceCommandHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
    {
        Service service = new()
        {
            Description = request.Description,
            IconUrl = request.IconUrl,
            Title = request.Title
        };
        await _repository.CreateAsync(service);
    }
}
