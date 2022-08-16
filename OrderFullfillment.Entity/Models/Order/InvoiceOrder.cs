using OrderFullfillment.Entity.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Entity.Models.Order
{
    public class InvoiceOrder : BaseModel
    {
        public enum OrderType
        {
            Company,
            Personal
        }
        public int InvoiceId { get; set; }
        public OrderType Type { get; set; }
        public List<OrderProduct> Products { get; set; }
    }
}
