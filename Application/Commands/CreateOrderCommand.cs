using MediatR;

namespace store_api.Application.Commands;

public class CreateOrderCommand : IRequest<Guid>
{
    public string CustomerName { get; set; } = string.Empty;
}