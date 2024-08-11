using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;
public sealed class CreateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public CreateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCarCommand command)
    {
        Car car = new()
        {
            BigImageUrl = command.BigImageUrl,
            BrandId = command.BrandId,
            CoverImageUrl = command.CoverImageUrl,
            Fuel = command.Fuel,
            Km = command.Km,
            Luggage = command.Luggage,
            Model = command.Model,
            Seat = command.Seat,
            Transmission = command.Transmission
        };
        await _repository.CreateAsync(car);
    }

}
