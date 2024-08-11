using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TestimonialCommands;
public sealed class RemoveTestimonialCommand : IRequest
{
    public int Id { get; set; }

    public RemoveTestimonialCommand(int id)
    {
        Id = id;
    }
}
