﻿using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandlers;
public sealed class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
{
    private readonly IRepository<Feature> _repository;

    public UpdateFeatureCommandHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        value.Name = request.Name;
        await _repository.UpdateAsync(value);
    }
}
