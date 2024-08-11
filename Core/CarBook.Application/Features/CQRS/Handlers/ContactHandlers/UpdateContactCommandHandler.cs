using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
public sealed class UpdateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public UpdateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateContactCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        value.SendDate = command.SendDate;
        value.Subject = command.Subject;
        value.Email = command.Email;
        value.Message = command.Message;
        value.Name = command.Name;
        await _repository.UpdateAsync(value);
    }
}
