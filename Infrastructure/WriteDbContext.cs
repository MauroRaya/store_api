using Microsoft.EntityFrameworkCore;
using store_api.Domain.Entities;

namespace store_api.Infrastructure;

public class WriteDbContext : DbContext
{
    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options) {}
    
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
}