using NewsPortalWebApi.Data_Access.EFCore;
using NewsPortalWebApi.Data_Access.EFCore.Repositories;
using NewsPortalWebApi.Data_Access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Data_Access.EFCore.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly NewsPortalWebApiContext db;
        private IRepository<News> newsRepository;

        public EFUnitOfWork(NewsPortalWebApiContext context)
        {
            db = context;
        }

        public IRepository<News> NewsRep
        { get
            {
                if (newsRepository == null)
                    newsRepository = new NewsRepository(db);
                return newsRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
