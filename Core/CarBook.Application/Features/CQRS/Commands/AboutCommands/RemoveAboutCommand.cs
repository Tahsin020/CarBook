namespace CarBook.Application.Features.CQRS.Commands.AboutCommands;
public sealed class RemoveAboutCommand(int id)
{
    public int Id { get; set; } = id;
}
