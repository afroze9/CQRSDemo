using CQRSDemo.Dtos;
using CQRSDemo.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSDemo.Mapping
{
    public class Mapper : IMapper
    {
        public List<OrderResponse> MapOrderDtosToOrderResponses(List<OrderDto> orders)
        {
            throw new NotImplementedException();
        }

        public OrderResponse MapOrderDtoToOrderResponse(OrderDto order)
        {
            throw new NotImplementedException();
        }
    }
}
