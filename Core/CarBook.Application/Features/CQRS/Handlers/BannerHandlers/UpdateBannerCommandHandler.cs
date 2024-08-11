using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
public sealed class UpdateBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public UpdateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBannerCommand command)
    {
        var banner = await _repository.GetByIdAsync(command.Id);
        banner.VideoDescription = command.VideoDescription;
        banner.Title = command.Title;
        banner.Description = command.Description;
        banner.VideoUrl = command.VideoUrl;
        await _repository.UpdateAsync(banner);
    }
}
