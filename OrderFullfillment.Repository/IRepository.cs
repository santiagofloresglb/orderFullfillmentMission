using OrderFullfillment.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFullfillment.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        Task<T> Get(int id);
    }
}
