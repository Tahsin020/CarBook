namespace CarBook.Application.Features.CQRS.Commands.CategoryCommands;
public sealed class RemoveCategoryCommand
{
    public int Id { get; set; }

    public RemoveCategoryCommand(int id)
    {
        Id = id;
    }
}
