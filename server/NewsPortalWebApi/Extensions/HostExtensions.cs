using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NewsPortalWebApi.Extensions
{
    /// <summary>
    /// Методы расширения для IHost
    /// </summary>
    public static class HostExtensions
    {
        /// <summary>
        /// Миграция БД
        /// </summary>
        /// <typeparam name="TContext">Тип контекста БД</typeparam>
        /// <param name="host"><see cref="IHost"/></param>
        /// <param name="seed">Опция заполнения данных</param>
        /// <returns><see cref="IHost"/></returns>
        public static IHost MigrateDatabase<TContext>(this IHost host, Action<TContext, IServiceProvider> seed = null) where TContext : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<TContext>();
                dbContext.Database.Migrate();

                seed?.Invoke(dbContext, scope.ServiceProvider.GetService<IServiceProvider>());
            }

            return host;
        }
    }
}
