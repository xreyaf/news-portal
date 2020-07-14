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
        private readonly NewsPortalWebApiContext _db;
        private IRepository<News> _newsRepository;
        private IRepository<Author> _authorsRepository;

        /// <summary>
        /// Конструктор класса для работы репозитория
        /// </summary>
        /// <param name="context">
        /// Контекст из базы данных
        /// </param>
        public EFUnitOfWork(NewsPortalWebApiContext context)
        {
            _db = context;
        }
        /// <summary>
        /// Получение репозитория новостей
        /// </summary>
        public IRepository<News> GetNewsRep
        { 
            get
            {
                if (_newsRepository == null)
                    _newsRepository = new NewsRepository(_db);
                return _newsRepository;
            }
        }
        /// <summary>
        /// Получение репозитория новостей
        /// </summary>
        public IRepository<Author> GetAuthorsRep
        {
            get
            {
                if (_authorsRepository == null)
                    _authorsRepository = new AuthorsRepository(_db);
                return _authorsRepository;
            }
        }
        /// <summary>
        /// Сохранение изменений
        /// </summary>
        public void Save()
        {
            _db.SaveChanges();
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
                    _db.Dispose();
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
