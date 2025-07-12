using DummyReactBack.Data;
using DummyReactBack.ModalView;
using DummyReactBack.Models;
using DummyReactBack.Models.ComputingParts;
using Microsoft.AspNetCore.Mvc;

namespace DummyReactBack.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    private readonly ApplicationContext _context;

    public ProductController(ILogger<ProductController> logger, ApplicationContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetProduct(int id)
    {
        var product = _context.Products.FirstOrDefault(x => x.Id == id);
        return Json(product);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddComputingDevice(ComputingDeviceModelView device)
    {
        if (ModelState.IsValid)
        {
            _context.Products.Add(device.Product);
            _context.CPUs.Add(device.CPU);
            _context.Cameras.Add(device.Camera);
            var cd = new ComputingDevice { Product = device.Product, Cpu = device.CPU, Camera = device.Camera };
            _context.ComputingDevices.Add(cd);
            await _context.SaveChangesAsync();
            return Ok();
        }
        return BadRequest();
    }

    [HttpGet]
    public IActionResult GetCpus()
    {
        return Json(_context.CPUs.ToList());
    }
    
    [HttpPost]
    public async Task<IActionResult> AddCpu(CpuModelView cpu)
    {
        if (ModelState.IsValid)
        {
            _context.CPUs.Add(new CPU
            {
                BrandId = cpu.BrandId, 
                CpuCores = cpu.CpuCores,
                GpuCores = cpu.GpuCores,
                Speed = cpu.Speed,
                Model = cpu.Model,
            });
            
            await _context.SaveChangesAsync();
            return Ok();
        }
        return BadRequest();
    }
}