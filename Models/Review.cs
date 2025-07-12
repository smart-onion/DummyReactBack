namespace DummyReactBack.Models;

public class Review
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public required Product Product { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }
    public string? Message { get; set; }
    public double Rating { get; set; }
    public DateTime ReviewDate { get; set; }
}