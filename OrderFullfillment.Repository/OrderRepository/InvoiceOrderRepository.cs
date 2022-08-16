using OrderFullfillment.Entity.Models.Order;
using OrderFullfillment.Entity.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Repository.OrderRepository
{
    public class InvoiceOrderRepository : IRepository<InvoiceOrder>
    {
        private readonly List<InvoiceOrder> _orders = new List<InvoiceOrder>()
        {
            new InvoiceOrder
            {
                Id = 1,
                InvoiceId = 1,
                Type = InvoiceOrder.OrderType.Personal,
                Products = new List<OrderProduct>
                {
                    new OrderProduct
                    {
                        Id = 1,
                        Price = 100,
                        Name = "Product 1"
                    }
                }
            },
            new InvoiceOrder
            {
                Id = 2,
                InvoiceId = 2,
                Type = InvoiceOrder.OrderType.Personal,
                Products = new List<OrderProduct>
                {
                    new OrderProduct
                    {
                        Id = 1,
                        Price = 100,
                        Name = "Product 1"
                    }
                }
            },
            new InvoiceOrder
            {
                Id = 3,
                InvoiceId = 3,
                Type = InvoiceOrder.OrderType.Company,
                Products = new List<OrderProduct>
                {
                    new OrderProduct
                    {
                        Id = 1,
                        Price = 100,
                        Name = "Product 1"
                    }
                }
            },
            new InvoiceOrder
            {
                Id = 4,
                InvoiceId = 4,
                Type = InvoiceOrder.OrderType.Company,
                Products = new List<OrderProduct>
                {
                    new OrderProduct
                    {
                        Id = 1,
                        Price = 100,
                        Name = "Product 1"
                    }
                }
            }
        };

        public async Task<InvoiceOrder> Get(int id)
        {
            return _orders.FirstOrDefault(x => x.Id == id);
        }
    }
}
