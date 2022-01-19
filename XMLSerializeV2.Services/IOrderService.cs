using XMLSerializeV2.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializeV2.Services
{
    public interface IOrderService
    {
        void Add(Order model);
        void Remove(Guid id);
        void Update(Order model);
        Order Get(Guid id);
        List<Order> GetAll();
    }
}
