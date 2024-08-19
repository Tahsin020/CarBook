using CarBook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
public sealed class GetTagCloudByBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResult>>
{
    public int Id { get; set; }

    public GetTagCloudByBlogIdQuery(int id)
    {
        Id = id;
    }
}
