namespace CarBook.Application.Features.CQRS.Commands.BannerCommands;
public sealed class RemoveBannerCommand
{
    public int Id { get; set; }

    public RemoveBannerCommand(int id)
    {
        Id = id;
    }
}
