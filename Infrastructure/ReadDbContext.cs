using Microsoft.EntityFrameworkCore;
using store_api.Domain.Entities;

namespace store_api.Infrastructure;

public class ReadDbContext : DbContext
{
    public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options) {}
    
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
}