using CQRSDemo.Commands;
using CQRSDemo.Dtos;
using CQRSDemo.Mapping;
using CQRSDemo.Repositories;
using CQRSDemo.Responses;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.Handlers
{
    public class CreateCustomerOrderHandler : IRequestHandler<CreateCustomerOrderCommand, OrderResponse>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateCustomerOrderHandler> _logger;

        public CreateCustomerOrderHandler(IOrdersRepository ordersRepository, IMapper mapper, ILogger<CreateCustomerOrderHandler> logger)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<OrderResponse> Handle(CreateCustomerOrderCommand request, CancellationToken cancellationToken)
        {
            OrderDto order = await _ordersRepository.CreateOrderAsync(request.CustomerId, request.ProductId);
            _logger.LogInformation($"Created order for customer: {order.CustomerId} for product: {order.ProductId}");
            return _mapper.MapOrderDtoToOrderResponse(order);

            throw new NotImplementedException();
        }
    }
}
