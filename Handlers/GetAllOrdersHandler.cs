using CQRSDemo.Dtos;
using CQRSDemo.Mapping;
using CQRSDemo.Queries;
using CQRSDemo.Repositories;
using CQRSDemo.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<OrderResponse>>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;

        public GetAllOrdersHandler(IOrdersRepository ordersRepository, IMapper mapper)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderResponse>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            List<OrderDto> orders = await _ordersRepository.GetOrdersAsync();
            return _mapper.MapOrderDtosToOrderResponses(orders);
        }
    }
}
