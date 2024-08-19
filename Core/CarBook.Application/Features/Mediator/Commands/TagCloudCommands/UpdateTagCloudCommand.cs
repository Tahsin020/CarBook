using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TagCloudCommands;
public sealed class UpdateTagCloudCommand : IRequest
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int BlogId { get; set; }
}
