namespace CarBook.Application.Features.CQRS.Commands.CarCommands;
public sealed class RemoveCarCommand
{
    public int Id { get; set; }

    public RemoveCarCommand(int id)
    {
        Id = id;
    }
}
