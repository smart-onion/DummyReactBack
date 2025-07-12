using DummyReactBack.Data;
using DummyReactBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DummyReactBack.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;
    private readonly ApplicationContext _context;

    public CategoryController(ILogger<CategoryController> logger, ApplicationContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetCategories()
    {
        var categories = _context.Categories.ToList();
        return Json(categories);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddCategory(string categoryName, int sectionId)
    {
        if (ModelState.IsValid)
        {
            _context.Categories.Add(new  Category() { Name = categoryName, SectionId = sectionId });
            await _context.SaveChangesAsync();
            return Ok();
        }
        return BadRequest();
    }
}