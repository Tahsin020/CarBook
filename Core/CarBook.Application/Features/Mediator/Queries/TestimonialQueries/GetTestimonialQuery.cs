using CarBook.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.TestimonialQueries;
public sealed class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
{
}
