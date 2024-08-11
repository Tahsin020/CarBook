using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.LocationCommands;
public sealed class RemoveLocationCommand : IRequest
{
    public int Id { get; set; }

    public RemoveLocationCommand(int id)
    {
        Id = id;
    }
}
