namespace CarBook.Application.Features.CQRS.Commands.ContactCommands;
public sealed class RemoveContactCommand
{
    public int Id { get; set; }

    public RemoveContactCommand(int id)
    {
        Id = id;
    }
}
