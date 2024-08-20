﻿using CarBook.Dto.BrandDtos;
using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers;
public class AdminCarController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminCarController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7209/api/Cars/GetCarWithBrand");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCarWithBrandsDto>>(jsonData);
            return View(values);
        }
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> CreateCar()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7209/api/Brands");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultBrandDto>>(jsonData);
        List<SelectListItem> brandListItems = (from x in values select new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
        ViewBag.BrandValues = brandListItems;
        return View();
    }
}
