using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
public sealed class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
{
}
