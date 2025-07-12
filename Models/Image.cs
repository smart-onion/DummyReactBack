namespace DummyReactBack.Models;

public class Image
{
    public int Id { get; set; }
    public required string Path { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
}