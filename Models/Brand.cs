namespace DummyReactBack.Models;

public class Brand
{
     public int Id { get; set; }
     public required string Name { get; set; }
     public ICollection<Product> Product { get; } =  new List<Product>();
}