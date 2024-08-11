using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServiceCommands;
public sealed class CreateServiceCommand : IRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string IconUrl { get; set; }
}
