using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializeV2.Data.Models
{
    public class OrderToProduct
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
    }
}
