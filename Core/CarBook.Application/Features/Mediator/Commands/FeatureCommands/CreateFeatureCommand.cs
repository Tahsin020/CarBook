using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.FeatureCommands;
public sealed class CreateFeatureCommand : IRequest
{
    public string Name { get; set; }
}
