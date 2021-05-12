using CQRSDemo.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private List<OrderDto> _orderDtos;

        public OrdersRepository()
        {
            _orderDtos = new List<OrderDto>();
        }

        public async Task<OrderDto> CreateOrderAsync(Guid customerId, Guid productId)
        {
            OrderDto newOrder = new OrderDto
            {
                CustomerId = customerId,
                Delivered = false,
                DeliveryDate = DateTime.UtcNow,
                Id = Guid.NewGuid(),
                ProductId = productId
            };

            _orderDtos.Add(newOrder);

            return newOrder;
        }

        public async Task<OrderDto> GetOrderAsync(Guid orderId)
        {
            return _orderDtos.FirstOrDefault(o => o.Id == orderId);
        }

        public async Task<List<OrderDto>> GetOrdersAsync()
        {
            return _orderDtos.ToList();
        }
    }
}