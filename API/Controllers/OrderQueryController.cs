using MediatR;
using Microsoft.AspNetCore.Mvc;
using store_api.Application.Commands;
using store_api.Application.DTOs;
using store_api.Application.Queries;

namespace store_api.API.Controllers;

[ApiController]
[Route("api/order")]
public class OrderQueryController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderQueryController(IMediator mediator)
    {
        _mediator = mediator;    
    }
    
    [HttpGet("{orderId}")]
    public async Task<ActionResult<OrderDto>> GetOrderById(
        [FromRoute] Guid orderId)
    {
        var query = new GetOrderByIdQuery { OrderId = orderId };
        var order = await _mediator.Send(query);
        
        if (order is null)
            return NotFound();
        
        return Ok(order);
    }
}

