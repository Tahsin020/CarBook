using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TagCloudCommands;
public sealed class CreateTagCloudCommand : IRequest
{
    public string Title { get; set; }
    public int BlogId { get; set; }
}
