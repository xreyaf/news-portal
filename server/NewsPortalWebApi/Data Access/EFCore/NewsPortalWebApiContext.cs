using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsPortalWebApi;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Data_Access.EFCore
{
    /// <summary>
    /// Класс получения контекста из базы данных
    /// </summary>
    public class NewsPortalWebApiContext : DbContext
    {
        /// <summary>
        /// Создание набора данных
        /// </summary>
        public DbSet<News> News { get; set; }
        /// <summary>
        /// Получение контекста из базы данных
        /// </summary>
        /// <param name="options"></param>
        public NewsPortalWebApiContext (DbContextOptions<NewsPortalWebApiContext> options)
            : base(options)
        {

        }

    }
}
