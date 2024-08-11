namespace CarBook.Application.Features.CQRS.Queries.CarQueries;
public sealed class GetCarByIdQuery
{
    public int Id { get; set; }

    public GetCarByIdQuery(int id)
    {
        Id = id;
    }
}
