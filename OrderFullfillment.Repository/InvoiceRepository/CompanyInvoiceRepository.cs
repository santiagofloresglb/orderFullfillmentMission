using OrderFullfillment.Entity.Models.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Repository.InvoiceRepository
{
    public class CompanyInvoiceRepository : IRepository<CompanyInvoice>
    {
        public Task<CompanyInvoice> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
