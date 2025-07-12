namespace DummyReactBack.Models;

public class TagProduct
{
    public int ProductId { get; set; }
    public int TagId { get; set; }
    public Tag Tag { get; set; }
    public Product Product { get; set; }
}