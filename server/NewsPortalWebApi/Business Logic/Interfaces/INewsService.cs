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
    /// <typeparam name="TAuthor"></typeparam>
    public interface INewsService<TShort, TDetail, TAuthor> 
        where TShort : class
        where TDetail : class
        where TAuthor : class
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
        /// <summary>
        /// Получение группы новостей
        /// </summary>
        /// <returns>Возвращает группу из нескольких новостей</returns>
        IEnumerable<TShort> GetGroupNews(int page);
        /// <summary>
        /// Получение имени автора по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TAuthor GetAuthorName(Guid id);
    }
}
