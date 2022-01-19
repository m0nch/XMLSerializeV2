using XMLSerializeV2.Data.DB;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLSerializeV2.Data.Models;

namespace XMLSerializeV2.Data
{
    public static class DataInjection
    {
        public static IServiceCollection AddData(this IServiceCollection service)
        {
            service.AddSingleton<IFileManager<Order>, FileManager<Order>>();
            service.AddSingleton<IFileManager<Product>, FileManager<Product>>();
            service.AddSingleton<IFileManager<OrderToProduct>, FileManager<OrderToProduct>>();
            return service;
        }  
    }
}
