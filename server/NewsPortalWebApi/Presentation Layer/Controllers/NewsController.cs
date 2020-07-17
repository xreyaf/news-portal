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
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Presentation_Layer.Controllers
{
    /// <summary>
    /// Контроллер представления новостей
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        /// <summary>
        /// Конструктор контроллера
        /// </summary>
        public NewsController(INewsService services)
        {
            _newsService = services;
        }
        /// <summary>
        /// Метод представления всех новостей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<NewsShortDto> GetAllNews()
        {
            return _newsService.GetAllNews();
        }
        /// <summary>
        /// Метод для предоставления групп новостей по 10 штук
        /// </summary>
        /// <param name="page"></param>
        /// <returns>Четыре новости</returns>
        [HttpGet("page")]
        public IEnumerable<NewsShortDto> GetGroup(int page)
        {
            return _newsService.GetGroupNews(page);
        }
        /// <summary>
        /// Удаление новости
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("news")]
        public void DeleteNews(Guid id)
        {
            _newsService.Delete(id);
        }

        /// <summary>
        /// Отправляет в бд новостную запись
        /// </summary>
        /// <param name="news">Новость в формате json</param>
        [HttpPost("addNews")]
        public void AddNews(NewsDetailDto news)
        {
            _newsService.Add(news);
        }
        /// <summary>
        /// Перезаписывает уже существующую запись в бд
        /// </summary>
        /// <param name="news"></param>
        [HttpPost("updateNews")]
        public void UpdateNews(NewsDetailDto news)
        {
            _newsService.Update(news);
        }
        /// <summary>
        /// Метод представления новости по id
        /// </summary>
        /// <param name="id">
        /// Id новости
        /// </param>
        /// <returns>
        /// Возвращает новость по id
        /// </returns>
        [HttpGet("id")]
        public NewsMainDto GetNews(Guid id)
        {
            return _newsService.GetNews(id);
        }
    }
}
