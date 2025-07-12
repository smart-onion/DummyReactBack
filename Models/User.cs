﻿using Microsoft.AspNetCore.Identity;

namespace DummyReactBack.Models;

public class User : IdentityUser
{
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}