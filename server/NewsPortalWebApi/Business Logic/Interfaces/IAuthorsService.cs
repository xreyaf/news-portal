using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Business_Logic.DTO;

namespace NewsPortalWebApi.Business_Logic.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса работы с авторами
    /// </summary>
    public interface IAuthorsService
    {
        /// <summary>
        /// Получение автора по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AuthorDTO GetAuthor(Guid id);

        /// <summary>
        /// Получение списка всех авторов
        /// </summary>
        IEnumerable<AuthorDTO> GetAuthors();
    }
}
