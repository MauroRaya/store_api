using store_api.Domain.Aggregates;
using store_api.Domain.Entities;

namespace store_api.Domain.Repositories;

public interface IOrderRepository
{
    Task<Order?> GetOrderByIdAsync(Guid orderId);
    Task SaveOrderAsync(OrderAggregate orderAggregate);
}