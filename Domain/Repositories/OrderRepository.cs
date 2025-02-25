using Microsoft.EntityFrameworkCore;
using store_api.Domain.Aggregates;
using store_api.Domain.Entities;
using store_api.Infrastructure;

namespace store_api.Domain.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ReadDbContext _readDbcontext;
    private readonly WriteDbContext _writeDbContext;

    public OrderRepository(ReadDbContext readDbcontext, WriteDbContext writeDbContext)
    {
        _readDbcontext = readDbcontext;
        _writeDbContext = writeDbContext;
    }
    
    public async Task<Order?> GetOrderByIdAsync(Guid orderId)
    {
        return await _readDbcontext.Orders
            .Where(o => o.Id == orderId)
            .FirstOrDefaultAsync();
    }

    public async Task SaveOrderAsync(OrderAggregate orderAggregate)
    {
        var order = orderAggregate.Order;
        await _writeDbContext.AddAsync(order);
        await _writeDbContext.SaveChangesAsync();
    }
}