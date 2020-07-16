using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NewsPortalWebApi.Data_Access.EFCore;
using NewsPortalWebApi.Data_Access.Models;
using NewsPortalWebApi.Extensions;

namespace NewsPortalWebApi
{
    /// <summary>
    /// Класс описывающий точку входа в приложение и запускающий последующие службы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Инициализация хоста
        /// </summary>
#pragma warning disable CS1998 // В асинхронном методе отсутствуют операторы await, будет выполнен синхронный метод
        public static async Task Main(string[] args)
#pragma warning restore CS1998 // В асинхронном методе отсутствуют операторы await, будет выполнен синхронный метод
        {
            var host = CreateHostBuilder(args).Build().MigrateDatabase<NewsPortalWebApiContext>();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    SampleData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }
            host.Run();
        }
        /// <summary>
        /// Создание хоста
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
