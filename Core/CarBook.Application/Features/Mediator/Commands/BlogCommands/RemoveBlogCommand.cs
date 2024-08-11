using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.BlogCommands;
public sealed class RemoveBlogCommand : IRequest
{
    public int Id { get; set; }

    public RemoveBlogCommand(int id)
    {
        Id = id;
    }
}
