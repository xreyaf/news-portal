using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.Inerfaces
{
    /// <summary>
    /// Интерфейс служб для работы с новостями
    /// </summary>
    /// <typeparam name="TShort"></typeparam>
    /// <typeparam name="TDetail"></typeparam>
    public interface INewsService<TShort, TDetail> 
        where TShort : class
        where TDetail : class

    {
        /// <summary>
        /// Получение новости по id
        /// </summary>
        /// <param name="id">
        /// id новости
        /// </param>
        /// <returns>
        /// Возвращает новость
        /// </returns>
        TDetail GetNews(Guid id);
        /// <summary>
        /// Получение всех новостей
        /// </summary>
        /// <returns>
        /// Возвращение всех новостей
        /// </returns>
        IEnumerable<TShort> GetAllNews();
    }
}
