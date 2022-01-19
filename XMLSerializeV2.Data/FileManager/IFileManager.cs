using XMLSerializeV2.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializeV2.Data.DB
{
    public interface IFileManager<T>
    {
        string XmlOrder { get; set; }
        string XmlProduct { get; set; }
        string XmlOrderToProduct { get; set; }
        void Write(List<T> model, string file);
        List<T> Read(string file);
    }
}
