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
        private readonly NewsPortalWebApiContext _db;
        private readonly IRepository<News> _newsRepository;

        public EFUnitOfWork(NewsPortalWebApiContext context)
        {
            _db = context;
        }

        public IRepository<News> NewsRep
        { get
            {
                if (_newsRepository == null)
                    _newsRepository = new NewsRepository(_db);
                return _newsRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
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
