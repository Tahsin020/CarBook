namespace CarBook.Application.Features.CQRS.Queries.AboutQueries;
public sealed class GetAboutByIdQuery
{
    public GetAboutByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
