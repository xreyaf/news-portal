using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsPortalWebApi.Business_Logic.DTO;
using NewsPortalWebApi.Business_Logic.Interfaces;
using NewsPortalWebApi.Data_Access.Interfaces;

namespace NewsPortalWebApi.Presentation_Layer.Controllers
{
    /// <summary>
    /// Контроллер взаимодействия с авторами
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;
        /// <summary>
        /// Контроллер для отображения методов работы с авторами
        /// </summary>
        /// <param name="service"></param>
        public AuthorsController(IAuthorsService service)
        {
            _authorsService = service;
        }

        /// <summary>
        /// представление имени автора по id
        /// </summary>
        /// <param name="id">
        /// id автора
        /// </param>
        /// <returns>
        /// Возвращает имя автора по id
        /// </returns>
        [HttpGet("authorId")]
        public string GetAuthorName(Guid id)
        {
            return _authorsService.GetAuthor(id).Name;
        }
        /// <summary>
        /// Возвращает список всех авторов
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<AuthorDTO> GetAllAuthors()
        {
            return _authorsService.GetAuthors();
        }
    }
}
