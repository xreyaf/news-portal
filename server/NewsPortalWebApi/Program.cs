using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NewsPortalWebApi.Data_Access.EFCore;
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
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build().MigrateDatabase<NewsPortalWebApiContext>();
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
