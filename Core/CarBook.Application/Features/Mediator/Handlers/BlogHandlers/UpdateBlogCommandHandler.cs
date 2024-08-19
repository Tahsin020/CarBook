using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;
public sealed class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
{
    private readonly IRepository<Blog> _repository;

    public UpdateBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        value.AuthorId = request.AuthorId;
        value.CategoryId = request.CategoryId;
        value.CreatedDate = request.CreatedDate;
        value.CoverImageUrl = request.CoverImageUrl;
        value.Title = request.Title;
        value.Description = request.Description;
        await _repository.UpdateAsync(value);
    }
}
