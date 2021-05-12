using CQRSDemo.Responses;
using MediatR;
using System;

namespace CQRSDemo.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderResponse>
    {
        public Guid OrderId { get; }
        public GetOrderByIdQuery(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
