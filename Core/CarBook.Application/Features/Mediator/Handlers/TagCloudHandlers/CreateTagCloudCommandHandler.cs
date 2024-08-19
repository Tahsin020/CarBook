﻿using CarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.TagCloudHandlers;
public sealed class CreateTagCloudCommandHandler : IRequestHandler<CreateTagCloudCommand>
{
    private readonly IRepository<TagCloud> _repository;

    public CreateTagCloudCommandHandler(IRepository<TagCloud> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
    {
        TagCloud tagCloud = new()
        {
            BlogId = request.BlogId,
            Title = request.Title
        };
        await _repository.CreateAsync(tagCloud);
    }
}
