using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServiceCommands;
public sealed class RemoveServiceCommand : IRequest
{
    public int Id { get; set; }

    public RemoveServiceCommand(int id)
    {
        Id = id;
    }
}
