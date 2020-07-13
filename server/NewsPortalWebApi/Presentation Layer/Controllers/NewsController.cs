using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsPortalWebApi;
using NewsPortalWebApi.Data_Access.Interfaces;
using NewsPortalWebApi.Data_Access.EFCore.Repositories;
using NewsPortalWebApi.Business_Logic.DTO;
using NewsPortalWebApi.Business_Logic.Inerfaces;
using NewsPortalWebApi.Business_Logic.Services;

namespace NewsPortalWebApi.Presentation_Layer.Controllers
{
    /// <summary>
    /// Контроллер представления новостей
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService<NewsShortDto> newsService;
        /// <summary>
        /// Конструктор контроллера
        /// </summary>
        public NewsController(INewsService<NewsShortDto> services)
        {
            newsService = services;
        }
        /// <summary>
        /// Метод представления всех новостей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<NewsShortDto> GetAllNews()
        {
            return newsService.GetAllNews();
        }
        /// <summary>
        /// Метод представления новости по Id
        /// </summary>
        /// <param name="Id">
        /// Id новости
        /// </param>
        /// <returns>
        /// Возвращает новость по Id
        /// </returns>
        [HttpGet("{id}")]
        public NewsShortDto GetNews(Guid Id)
        {
            return newsService.GetNews(Id);
        }
    }
}
