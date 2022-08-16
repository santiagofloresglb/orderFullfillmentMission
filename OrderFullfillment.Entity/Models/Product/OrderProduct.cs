using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Entity.Models.Product
{
    public class OrderProduct : BaseModel
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
