using MediatR;
using store_api.Application.DTOs;

namespace store_api.Application.Queries;

public class GetOrderByIdQuery : IRequest<OrderDto>
{
    public Guid OrderId { get; set; }
}