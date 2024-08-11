using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
public sealed class GetAboutByIdQueryHandler
{
    private readonly IRepository<About> _context;

    public GetAboutByIdQueryHandler(IRepository<About> context)
    {
        _context = context;
    }

    public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
    {
        var value = await _context.GetByIdAsync(query.Id) ?? throw new Exception("Hakkımda bulunamadı");
        return new()
        {
            Id = value.Id,
            Description = value.Description,
            ImageUrl = value.ImageUrl,
            Title = value.Title
        };
    }
}
