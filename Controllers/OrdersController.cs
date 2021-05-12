using CQRSDemo.Commands;
using CQRSDemo.Queries;
using CQRSDemo.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSDemo.Controllers
{
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateCustomerOrderCommand command)
        {
            OrderResponse result = await _mediator.Send(command);
            return CreatedAtAction("GetOrder", new { orderId = result.Id }, result);
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrder(Guid orderId)
        {
            GetOrderByIdQuery query = new GetOrderByIdQuery(orderId);
            OrderResponse result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrder()
        {
            GetAllOrdersQuery query = new GetAllOrdersQuery();
            List<OrderResponse> result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}