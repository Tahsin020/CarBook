﻿using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;
public sealed class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
{
    private readonly IBlogRepository _repository;

    public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetAllBlogsWithAuthors();
        return values.Select(x => new GetAllBlogsWithAuthorQueryResult
        {
            AuthorId = x.AuthorId,
            Id = x.Id,
            CategoryId = x.CategoryId,
            CoverImageUrl = x.CoverImageUrl,
            CreatedDate = x.CreatedDate,
            Title = x.Title,
            AuthorName = x.Author.Name,
            Description = x.Description,
            AuthorDescription = x.Author.Description,
            AuthorImage = x.Author.ImageUrl,
            CategoryName = x.Category.Name,
        }).ToList();
    }
}
