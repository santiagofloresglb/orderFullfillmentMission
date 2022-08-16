using OrderFullfillment.Entity.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Entity.Models.Basket
{
    public class Basket : BaseModel
    {
        public int Id { get; set; }
        public List<OrderProduct> Products { get; set; }
    }
}
