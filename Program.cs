using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
            // внедряем сервисы
            .ConfigureServices(services =>
            {
                services.AddSingleton<App>();
                services.AddSingleton<MainWindow>();
            })
            .Build();
            // получаем сервис - объект класса App
            var app = host.Services.GetService<App>();
            // запускаем приложения
            app?.Run();
        }

    }
}
