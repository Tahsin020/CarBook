namespace CarBook.Application.Features.CQRS.Commands.CategoryCommands;
public sealed class UpdateCategoryCommand
{
    public int Id { get; set; }
    public string Name { get; set; }
}
