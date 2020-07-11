using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsPortalWebApi;

namespace NewsPortalWebApi.Data
{
    public class NewsPortalWebApiContext : DbContext
    {
        public DbSet<NewsPortalWebApi.News> News { get; set; }

        public NewsPortalWebApiContext (DbContextOptions<NewsPortalWebApiContext> options)
            : base(options)
        {

        }

    }
}
