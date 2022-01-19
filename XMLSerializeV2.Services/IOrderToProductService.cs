using XMLSerializeV2.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializeV2.Services
{
    public interface IOrderToProductService
    {
        void Add(OrderToProduct model);
        void Remove(Guid id);
        void RemoveAll(Guid id);
        List<Product> GetAllByOrder(Guid id);
        List<Order> GetAllByProduct(Guid id);
    }
}
