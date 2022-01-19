using XMLSerializeV2.Data;
using XMLSerializeV2.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLSerializeV2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureService(services);

            using(ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureService(IServiceCollection services)
        {
            services.AddSingleton<_IAppCache, _AppCache>();

            services.AddData()
                    .AddServices()
                    .AddScoped<MainForm>()
                    .AddScoped<OrderForm>();
        }
    }
}
