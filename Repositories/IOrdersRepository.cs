using CQRSDemo.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSDemo.Repositories
{
    public interface IOrdersRepository
    {
        Task<OrderDto> CreateOrderAsync(Guid customerId, Guid productId);
        Task<OrderDto> GetOrderAsync(Guid orderId);
        Task<List<OrderDto>> GetOrdersAsync();
    }
}