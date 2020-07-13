using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsPortalWebApi;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Data_Access.EFCore
{
    public class NewsPortalWebApiContext : DbContext
    {
        public DbSet<News> News { get; set; }

        public NewsPortalWebApiContext (DbContextOptions<NewsPortalWebApiContext> options)
            : base(options)
        {

        }

    }
}
