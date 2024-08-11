using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
public sealed class CreateSocialMediaCommand : IRequest
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
}
