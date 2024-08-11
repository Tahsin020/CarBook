using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries;
public sealed class GetBlogByIdQuery : IRequest<GetBlogByIdQueryResult>
{
    public int Id { get; set; }

    public GetBlogByIdQuery(int id)
    {
        Id = id;
    }
}
