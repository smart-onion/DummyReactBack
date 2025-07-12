namespace DummyReactBack.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int CategoryId { get; set; }
    public required Category Category { get; set; }
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public double Price { get; set; }
    public double Discount { get; set; }
    public string? Description { get; set; }
    public string? Model { get; set; }
    public int BrandId { get; set; }
    public required Brand Brand { get; set; }
    public double Weight { get; set; }
    public int Quantity { get; set; }
    public bool InStock { get; set; }
    public ICollection<Image> Images { get; set; } =  new List<Image>();
    public ICollection<Tag> Tags { get; set; } =  new List<Tag>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ComputingDevice ComputingDevice { get; set; }
    
}