using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Data_Access.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с репозиториями
    /// </summary>
    public interface IUnitOfWork : IDisposable 
    {
        /// <summary>
        /// получение репозитория новостей
        /// </summary>
        IRepository<News> GetNewsRep { get; }
        /// <summary>
        /// получение репозитория авторов
        /// </summary>
        IRepository<Author> GetAuthorsRep { get; }
        /// <summary>
        /// сохранение изменений
        /// </summary>
        void Save();
    }
}
