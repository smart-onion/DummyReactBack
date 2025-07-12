using Microsoft.AspNetCore.Mvc;

namespace DummyReactBack.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult GetProduct(int id)
    {
        return View();
    }
}