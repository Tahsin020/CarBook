﻿using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly CreateBrandCommandHandler _createBrandCommandHandler;
    private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
    private readonly GetBrandQueryHandler _getBrandQueryHandler;
    private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
    private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;

    public BrandsController(CreateBrandCommandHandler createBrandCommandHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler, GetBrandQueryHandler getBrandQueryHandler, RemoveBrandCommandHandler removeBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler)
    {
        _createBrandCommandHandler = createBrandCommandHandler;
        _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
        _getBrandQueryHandler = getBrandQueryHandler;
        _removeBrandCommandHandler = removeBrandCommandHandler;
        _updateBrandCommandHandler = updateBrandCommandHandler;
    }

    [HttpGet]
    public async Task<IActionResult> GetBrands()
    {
        var values = await _getBrandQueryHandler.Handle();
        return Ok(values);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBrand(int id)
    {
        var value = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
    {
        await _createBrandCommandHandler.Handle(command);
        return Ok("Marka bilgisi eklendi");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
    {
        await _updateBrandCommandHandler.Handle(command);
        return Ok("Marka bilgisi güncellendi");
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveBrand(RemoveBrandCommand command)
    {
        await _removeBrandCommandHandler.Handle(command);
        return Ok("Marka bilgisi silinid");
    }
}
