using CarBook.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.PricingQueries;
public sealed class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
{
}
