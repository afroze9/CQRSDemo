using CQRSDemo.Responses;
using MediatR;
using System;

namespace CQRSDemo.Commands
{
    public class CreateCustomerOrderCommand : IRequest<OrderResponse>
    {
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
    }
}