﻿namespace DummyReactBack.Models;

public class TagProduct
{
    public int TagId { get; set; }
    public Tag Tag { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}