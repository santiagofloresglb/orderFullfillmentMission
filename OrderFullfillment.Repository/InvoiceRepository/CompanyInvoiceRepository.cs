using OrderFullfillment.Entity.Models.Invoice;
using OrderFullfillment.Entity.Models.Order;
using OrderFullfillment.Entity.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Repository.InvoiceRepository
{
    public class CompanyInvoiceRepository : IRepository<CompanyInvoice>
    {
        private readonly List<CompanyInvoice> _companyInvoices = new List<CompanyInvoice>
        {
            new CompanyInvoice
            {
                Id = 3,
                Order = new InvoiceOrder
                {
                    Id = 100,
                    InvoiceId = 3,
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
            new CompanyInvoice
            {
                Id = 4,
                Order = new InvoiceOrder
                {
                    Id = 101,
                    InvoiceId = 4,
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

        public async Task<CompanyInvoice> Get(int id)
        {
            return _companyInvoices.FirstOrDefault(x => x.Id == id);
        }
    }
}
