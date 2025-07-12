using DummyReactBack.Data;
using DummyReactBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DummyReactBack.Controllers;

public class SectionController : Controller
{
    private readonly ILogger<ProductController> _logger;
    private readonly ApplicationContext _context;

    public SectionController(ILogger<ProductController> logger, ApplicationContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetSections()
    {
        var sections = _context.Sections.ToList();
        return Json(sections);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddSection(string sectionName)
    {
        if (ModelState.IsValid)
        {
            _context.Sections.Add(new Section() { Name = sectionName });
            await _context.SaveChangesAsync();
            return Ok();
        }
        return BadRequest();
    }
}