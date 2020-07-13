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
    /// <summary>
    /// Класс для работы с репозиториями
    /// </summary>
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly NewsPortalWebApiContext db;
        private IRepository<News> newsRepository;
        /// <summary>
        /// Конструктор класса для работы репозитория
        /// </summary>
        /// <param name="context">
        /// Контекст из базы данных
        /// </param>
        public EFUnitOfWork(NewsPortalWebApiContext context)
        {
            db = context;
        }
        /// <summary>
        /// Создание репозитория
        /// </summary>
        public IRepository<News> NewsRep
        { get
            {
                if (newsRepository == null)
                    newsRepository = new NewsRepository(db);
                return newsRepository;
            }
        }
        /// <summary>
        /// Сохранение изменений
        /// </summary>
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        /// <summary>
        /// Освобождение выделенных ресурсов для этого контекста
        /// </summary>
        /// <param name="disposing"></param>
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
        /// <summary>
        /// Пропуск финализации
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
