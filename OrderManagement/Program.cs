using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace OrderManagement
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new OrderManagement());

            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    #region Register Dependencies

                    services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog());
                    services.AddScoped<OrderManagement>();

                    #endregion

                    #region Run Form

                    var provider = services.BuildServiceProvider();
                    var mainForm = provider.GetRequiredService<OrderManagement>();
                    Application.Run(mainForm);

                    #endregion
                });

            builder.Build();
        }
    }
}
