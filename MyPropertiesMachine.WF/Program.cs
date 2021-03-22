using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyPropertiesMachine.Services.DependencyInyection;
using System;
using System.Windows.Forms;

namespace MyPropertiesMachine.WF
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var builder = new HostBuilder().ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<FrmInput>();
                    services.AddLogging(configure => configure.AddConsole());
                    ConfigureServices(services);
                }
            );

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var frmMachine = services.GetRequiredService<FrmInput>();
                    Application.Run(frmMachine);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Inicializa inyección de dependencias por medio del proyecto InjectionMachine.
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServices(IServiceCollection services)
        {
            InjectionMachine.AddRegistration(services);
        }
    }
}
