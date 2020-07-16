using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewsPortalWebApi.Data_Access.EFCore;

namespace NewsPortalWebApi.Extensions
{
    /// <summary>
    /// Класс автоматизации создания миграций
    /// </summary>
    public static class DataSeeder
    {
        /// <summary>
        /// Запись миграции
        /// </summary>
        /// <param name="app"></param>
        public static void SeedData(this IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetService<NewsPortalWebApiContext>();
            if (!context.Database.EnsureCreated())
            {
                context.Database.Migrate();
            }
        }
    }
}
