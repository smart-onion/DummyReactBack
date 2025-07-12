using DummyReactBack.Data;
using DummyReactBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DummyReactBack.Controllers;

public class BrandController : Controller
{
    private readonly ILogger<CategoryController> _logger;
    private readonly ApplicationContext _context;

    public BrandController(ILogger<CategoryController> logger, ApplicationContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetBrands()
    {
        var brands = _context.Brands.ToList();
        return Json(brands);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddBrand(string brandName)
    {
        if (ModelState.IsValid)
        {
            _context.Brands.Add(new  Brand() { Name = brandName });
            await _context.SaveChangesAsync();
            return Ok();
        }
        return BadRequest();
    }
}