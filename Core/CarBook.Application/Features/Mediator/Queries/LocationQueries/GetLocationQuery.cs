using CarBook.Application.Features.Mediator.Results.LocationResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.LocationQueries;
public sealed class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
{
}
