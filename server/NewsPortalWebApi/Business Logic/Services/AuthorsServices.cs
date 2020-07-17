using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NewsPortalWebApi.Business_Logic.DTO;
using NewsPortalWebApi.Business_Logic.Interfaces;
using NewsPortalWebApi.Data_Access.Interfaces;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Business_Logic.Services
{
    /// <summary>
    /// Сервис для работы с авторами
    /// </summary>
    public class AuthorsServices : IAuthorsService
    {
        /// <summary>
        /// Объект UnitOfWork для получения доступа к репозиториям
        /// </summary>
        private readonly IUnitOfWork _db;
        /// <summary>
        /// Объект библиотеки Mapper, содержащий в себе маппинг DTO's
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Создание службы работы с репозиториями
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="mapper"></param>
        public AuthorsServices(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }
        /// <summary>
        /// Получить всех авторов
        /// </summary>
        /// <returns>Список авторов</returns>
        public IEnumerable<AuthorDTO> GetAuthors()
        {
            var authors = _db.AuthorsRep.GetAll();
            return _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorDTO>>(authors);
        }

        /// <summary>
        /// Метод для получения Автора
        /// </summary>
        /// <param name="id">Id Автора</param>
        /// <returns>Возвращает объект Author</returns>
        public AuthorDTO GetAuthor(Guid id)
        {
            return _mapper.Map<AuthorDTO>(_db.AuthorsRep.Get(id));
        }
    }
}
