using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService;

    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    [HttpPost]
    public IActionResult Add(CreateBrandRequest brand)
    {
        CreatedBrandResponse createdBrandResponse = _brandService.Add(brand);

        return Ok(createdBrandResponse);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_brandService.GetAll());
    }
}
