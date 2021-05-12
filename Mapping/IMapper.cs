using CQRSDemo.Dtos;
using CQRSDemo.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDemo.Mapping
{
    public interface IMapper
    {
        OrderResponse MapOrderDtoToOrderResponse(OrderDto order);
        List<OrderResponse> MapOrderDtosToOrderResponses(List<OrderDto> orders);
    }
}
