using OrderFullfillment.Application.Interfaces;
using OrderFullfillment.Entity.Models.Order;
using OrderFullfillment.Repository;
using OrderFullfillment.Repository.OrderRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<InvoiceOrder> _orderRepository;

        public OrderService(IRepository<InvoiceOrder> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<InvoiceOrder> Get(int id)
        {
            return await _orderRepository.Get(id);
        }
    }
}
