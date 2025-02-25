using MediatR;
using store_api.Application.Commands;
using store_api.Domain.Aggregates;
using store_api.Domain.Repositories;

namespace store_api.Application.Handlers;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
{
    private readonly IOrderRepository _orderRepository;

    public CreateOrderCommandHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new OrderAggregate(request.CustomerName);
        await _orderRepository.SaveOrderAsync(order);
        return order.Order.Id;
    }
}