using Microsoft.EntityFrameworkCore;

namespace DummyReactBack.Models;

public class Section
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<Category> Categories { get; set; }
}