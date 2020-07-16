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

        /// <summary>
        /// Конструктор класса для работы репозитория
        /// </summary>
        /// <param name="context">
        /// Контекст из базы данных
        /// </param>
        /// <param name="newsRep">Новостной репозиторий</param>
        /// <param name="authorsRep">Репозиторий с авторами</param>
        public EFUnitOfWork(NewsPortalWebApiContext context, NewsRepository newsRep, AuthorsRepository authorsRep)
        {
            _db = context;
            GetNewsRep = newsRep;
            GetAuthorsRep = authorsRep;
        }
        /// <summary>
        /// Получение репозитория новостей
        /// </summary>
        public IRepository<News> GetNewsRep { get; }
        /// <summary>
        /// Получение репозитория новостей
        /// </summary>
        public IRepository<Author> GetAuthorsRep { get; }
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
