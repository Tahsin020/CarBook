namespace CarBook.Application.Features.CQRS.Queries.ContactQueries;
public sealed class GetContactByIdQuery
{
    public int Id { get; set; }

    public GetContactByIdQuery(int id)
    {
        Id = id;
    }
}
