using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderFullfillment.Entity.Models.Invoice;

namespace OrderFullfillment.Application.Interfaces
{
    public interface IInvoiceService : IServiceBase<InvoiceBase>
    {
        Task Sing(int orderId);
        Task Export(int orderId);
    }
}
