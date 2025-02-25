using MediatR;
using Microsoft.AspNetCore.Mvc;
using store_api.Application.Commands;
using store_api.Application.Queries;

namespace store_api.API.Controllers;

[ApiController]
[Route("api/order")]
public class OrderCommandController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderCommandController(IMediator mediator)
    {
        _mediator = mediator;    
    }
    
    [HttpPost]
    public async Task<ActionResult> CreateOrder(
        [FromBody] CreateOrderCommand command)
    {
        var orderId = await _mediator.Send(command);
        return Created($"api/order/{orderId}", orderId);
    }
}

