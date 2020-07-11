using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsPortalWebApi.Data_Access.Interfaces;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Data_Access.EFCore.Repositories
{
    public class NewsRepository : IRepository<News>        
    {
        private readonly NewsPortalWebApiContext context;
        public NewsRepository(NewsPortalWebApiContext context)
        {
            this.context = context;
        }
        public IEnumerable<News> GetAll()
        {
            return context.News;
        }
        public News Get(Guid id)
        {
            return context.News.Find(id);
        }

        public void Add(News entity)
        {
            context.Add(entity);
        }

        public void Delete(Guid id)
        {
            News entity = context.News.Find(id);
            if (entity != null)
                context.News.Remove(entity);
        }

        public void Update(News entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
