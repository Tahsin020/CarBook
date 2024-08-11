using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public sealed class CreateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public CreateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateContactCommand command)
    {
        Contact contact = new()
        {
            Email = command.Email,
            Message = command.Message,
            Name = command.Name,
            SendDate = command.SendDate,
            Subject = command.Subject
        };
        await _repository.CreateAsync(contact);
    }
}
