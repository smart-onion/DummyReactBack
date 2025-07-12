using DummyReactBack.Enums;

namespace DummyReactBack.Models;

public class Order
{
    public int Id { get; set; }
    public required ICollection<Product> Product { get; set; } = new List<Product>();
    public int UserId { get; set; }
    public required User User { get; set; }
    public OrderStatus  Status { get; set; }
    public int Quantity { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public DateTime CompleteDate { get; set; }
}