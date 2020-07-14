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
        private readonly NewsPortalWebApiContext _context;
        public NewsRepository(NewsPortalWebApiContext context)
        {
            this._context = context;
        }
        public IEnumerable<News> GetAll()
        {
            return _context.News;
        }
        public News Get(Guid id)
        {
            return _context.News.Find(id);
        }

        public void Add(News entity)
        {
            _context.Add(entity);
        }

        public void Delete(Guid id)
        {
            News entity = _context.News.Find(id);
            if (entity != null)
                _context.News.Remove(entity);
        }

        public void Update(News entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
