using CQRSDemo.Responses;
using MediatR;
using System.Collections.Generic;

namespace CQRSDemo.Queries
{
    public class GetAllOrdersQuery : IRequest<List<OrderResponse>>
    {

    }
}
