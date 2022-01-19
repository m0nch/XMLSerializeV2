using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerializeV2.Services
{
    public static class ServicesInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IOrderService, OrderService>();
            service.AddScoped<IOrderToProductService, OrderToProductService>();
            return service;
        }
    }
}
