using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderFullfillment.Entity.Models.Order;
using OrderFullfillment.Entity.Models.Product;

namespace OrderFullfillment.Entity.Models.Invoice
{
    public abstract class InvoiceBase : BaseModel
    {
        public string Customer { get; set; }
        public InvoiceOrder Order { get; set; }
        public abstract void Sing(int orderId);

        public virtual void Export(int invoiceId)
        {
            Console.WriteLine($"Begin export for Invoice with id: {invoiceId}");
            Console.WriteLine($"Exporting finished!");
        }
    }
}
