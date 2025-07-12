namespace DummyReactBack.Models;

public class OrderProduct
{
    public int ProductId { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;
}