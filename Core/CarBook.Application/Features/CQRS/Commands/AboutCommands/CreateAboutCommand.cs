namespace CarBook.Application.Features.CQRS.Commands.AboutCommands;
public sealed class CreateAboutCommand
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
