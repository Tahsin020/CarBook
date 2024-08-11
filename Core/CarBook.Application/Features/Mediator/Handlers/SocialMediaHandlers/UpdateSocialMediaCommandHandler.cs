using CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;
public sealed class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
{
    private readonly IRepository<SocialMedia> _repository;

    public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        SocialMedia socialMedia = await _repository.GetByIdAsync(request.Id);
        socialMedia.Url = request.Url;
        socialMedia.Name = request.Name;
        socialMedia.Icon = request.Icon;
        await _repository.UpdateAsync(socialMedia);
    }
}
