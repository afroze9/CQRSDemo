using CQRSDemo.Dtos;
using CQRSDemo.Mapping;
using CQRSDemo.Queries;
using CQRSDemo.Repositories;
using CQRSDemo.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Handlers
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderResponse>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;

        public GetOrderByIdHandler(IOrdersRepository ordersRepository, IMapper mapper)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }

        public async Task<OrderResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            OrderDto order = await _ordersRepository.GetOrderAsync(request.OrderId);
            return _mapper.MapOrderDtoToOrderResponse(order);
        }
    }
}
