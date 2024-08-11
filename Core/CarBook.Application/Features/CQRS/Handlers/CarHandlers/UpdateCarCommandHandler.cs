﻿using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;
public sealed class UpdateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public UpdateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateCarCommand command)
    {
        var value = await _repository.GetByIdAsync(command.CarId);
        value.Fuel = command.Fuel;
        value.Transmission = command.Transmission;
        value.BigImageUrl = command.BigImageUrl;
        value.BrandId = command.BrandId;
        value.CoverImageUrl = command.CoverImageUrl;
        value.Km = command.Km;
        value.Seat = command.Seat;
        value.Model = command.Model;
        value.Luggage = command.Luggage;
        await _repository.UpdateAsync(value);
    }
}
