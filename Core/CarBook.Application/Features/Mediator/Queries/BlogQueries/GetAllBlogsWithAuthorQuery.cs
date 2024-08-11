using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries;
public sealed class GetAllBlogsWithAuthorQuery :IRequest<List<GetAllBlogsWithAuthorQueryResult>>
{
}
