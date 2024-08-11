using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
public sealed class CreateAboutCommandHandler
{
    private readonly IRepository<About> _context;

    public CreateAboutCommandHandler(IRepository<About> context)
    {
        _context = context;
    }

    public async Task Handle(CreateAboutCommand command)
    {
        await _context.CreateAsync(new About
        {
            Description = command.Description,
            ImageUrl = command.ImageUrl,
            Title = command.Title
        });
    }
}
