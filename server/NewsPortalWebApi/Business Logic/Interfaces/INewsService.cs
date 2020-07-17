using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Business_Logic.DTO;

namespace NewsPortalWebApi.Business_Logic.Inerfaces
{
    /// <summary>
    /// Интерфейс служб для работы с новостями
    /// </summary>
    public interface INewsService
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
        NewsMainDto GetNews(Guid id);
        /// <summary>
        /// Получение всех новостей
        /// </summary>
        /// <returns>
        /// Возвращение всех новостей
        /// </returns>
        IEnumerable<NewsShortDto> GetAllNews();
        /// <summary>
        /// Получение группы новостей
        /// </summary>
        /// <returns>Возвращает группу из нескольких новостей</returns>
        IEnumerable<NewsShortDto> GetGroupNews(int page);
        /// <summary>
        /// Добавление новости в базу данных
        /// </summary>
        /// <param name="news">Новость</param>
        void Add(NewsDetailDto news);
        /// <summary>
        /// Обновление новости
        /// </summary>
        /// <param name="news"></param>
        void Update(NewsDetailDto news);
        /// <summary>
        /// Удаление по идентификатору
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);
        
    }
}
