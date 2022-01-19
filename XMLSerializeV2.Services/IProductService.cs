using XMLSerializeV2.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializeV2.Services
{
    public interface IProductService
    {
        void Add(Product model);
        void Remove(Guid id);
        void Update(Product model);
        Product Get(Guid id);
        List<Product> GetAll();
    }
}
