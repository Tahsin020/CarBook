﻿using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;
public sealed class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
{
    private readonly ICarPricingRepository _repository;

    public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
    {
        var values = _repository.GetCarPricingWithCars();
        return values.Select(x => new GetCarPricingWithCarQueryResult
        {
            Brand = x.Car.Brand.Name,
            CarId = x.Car.CarId,
            CarPricingId = x.Id,
            CoverImageUrl = x.Car.CoverImageUrl,
            Model = x.Car.Model,
            PricingAmount = x.Amount,
            PricingName = x.Pricing.Name
        }).ToList();

    }
}
