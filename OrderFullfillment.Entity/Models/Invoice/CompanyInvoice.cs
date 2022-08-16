using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Entity.Models.Invoice
{
    public class CompanyInvoice : InvoiceBase
    {
        public override void Sing(int orderId)
        {
            Console.WriteLine($"Singning order n°: {orderId} which belongs to a Company");
        }

        public override void Export(int invoiceId)
        {
            Console.WriteLine($"Company invoice export for Invoice with id: {invoiceId}");
            Console.WriteLine($"Exporting finished!");
        }
    }
}
