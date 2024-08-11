using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.FeatureCommands;
public sealed class UpdateFeatureCommand : IRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
}
