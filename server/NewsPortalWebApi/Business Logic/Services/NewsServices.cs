using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using NewsPortalWebApi.Data_Access.Interfaces;
using NewsPortalWebApi.Data_Access.Models;
using NewsPortalWebApi.Business_Logic.Inerfaces;
using NewsPortalWebApi.Business_Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.Services
{
    /// <summary>
    /// Класс служб для работы с новостями
    /// </summary>
    public class NewsServices : INewsService<NewsShortDto>
    {
        /// <summary>
        /// Создание служб по классу работы с репозиториями
        /// </summary>
        IUnitOfWork Db { get; set; }
        /// <summary>
        /// Создание служб по классу работы с репозиториями
        /// </summary>
        /// <param name="entity"></param>
        public NewsServices(IUnitOfWork entity)
        {
            Db = entity;
        }
        /// <summary>
        /// Метод получения новости по Id
        /// </summary>
        /// <param name="Id">
        /// Id новости
        /// </param>
        /// <remarks>
        /// Происходит проецирование модели News на NewsDetailDTO
        /// </remarks>
        /// <returns>
        /// Возвращает новость по ее Id
        /// </returns>
        public NewsShortDto GetNews(Guid Id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsShortDto>()).CreateMapper();
            return mapper.Map<News, NewsShortDto>(Db.NewsRep.Get(Id));
        }
        /// <summary>
        /// Метод получения всех новостей
        /// </summary>
        /// <remarks>
        /// Происходит проецирование модели News на NewsDetailDTO
        /// </remarks>
        /// <returns>
        /// Возвращает все новости
        /// </returns>
        public IEnumerable<NewsShortDto> GetAllNews()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsShortDto>()).CreateMapper();
            return mapper.Map<IEnumerable<News>, List<NewsShortDto>>(Db.NewsRep.GetAll());
        }
    }
}
