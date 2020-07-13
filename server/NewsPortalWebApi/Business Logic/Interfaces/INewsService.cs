using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.Inerfaces
{
    /// <summary>
    /// Интерфейс служб для работы с новостями
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface INewsService<T> where T : class
    {
        /// <summary>
        /// Получение новости по Id
        /// </summary>
        /// <param name="Id">
        /// Id новости
        /// </param>
        /// <returns>
        /// Возвращает новость
        /// </returns>
        T GetNews(Guid Id);
        /// <summary>
        /// Получение всех новостей
        /// </summary>
        /// <returns>
        /// Возвращение всех новостей
        /// </returns>
        IEnumerable<T> GetAllNews();
    }
}
