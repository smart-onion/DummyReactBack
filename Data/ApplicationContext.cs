using DummyReactBack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DummyReactBack.Data;

public class ApplicationContext : IdentityDbContext<User>
{
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Tag> Tags { get; set; }
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
         
    }
}