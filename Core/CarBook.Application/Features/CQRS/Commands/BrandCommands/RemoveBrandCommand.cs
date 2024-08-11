namespace CarBook.Application.Features.CQRS.Commands.BrandCommands;
public sealed class RemoveBrandCommand
{
    public int Id { get; set; }

    public RemoveBrandCommand(int id)
    {
        Id = id;
    }
}
