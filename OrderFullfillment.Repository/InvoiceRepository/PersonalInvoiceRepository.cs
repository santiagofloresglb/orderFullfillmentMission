using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderFullfillment.Entity.Models.Invoice;
using OrderFullfillment.Entity.Models.Order;
using OrderFullfillment.Entity.Models.Product;

namespace OrderFullfillment.Repository.InvoiceRepository
{
    public class PersonalInvoiceRepository : IRepository<PersonalInvoice>
    {
        private readonly List<PersonalInvoice> _personalInvoices = new List<PersonalInvoice>
        {
            new PersonalInvoice
            {
                Id = 1,
                Order = new InvoiceOrder
                {
                    Id = 100,
                    InvoiceId = 2,
                    Products = new List<OrderProduct>
                    {
                        new OrderProduct
                        {
                            Id = 10,
                            Price = 20
                        }
                    }
                }
            },
            new PersonalInvoice
            {
                Id = 2,
                Order = new InvoiceOrder
                {
                    Id = 101,
                    InvoiceId = 2,
                    Products = new List<OrderProduct>
                    {
                        new OrderProduct
                        {
                            Id = 10,
                            Price = 20
                        },
                        new OrderProduct
                        {
                            Id = 11,
                            Price = 40
                        }
                    }
                }
            }
        };
        public async Task<PersonalInvoice> Get(int id)
        {
            return _personalInvoices.FirstOrDefault(x => x.Id == id);
        }
    }
}
