using CarBook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.AuthorQueries;
public sealed class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
{
}
