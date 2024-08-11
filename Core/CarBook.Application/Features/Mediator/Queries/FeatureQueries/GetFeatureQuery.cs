using CarBook.Application.Features.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.FeatureQueries;
public sealed class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
{
}
