namespace DummyReactBack.Models;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int SectionId { get; set; }
    public Section Section { get; set; }
    public ICollection<Product> Products { get; } = new List<Product>();
}