using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using NewsPortalWebApi.Business_Logic.DTO;
using NewsPortalWebApi.Business_Logic.Inerfaces;
using NewsPortalWebApi.Data_Access.Interfaces;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Business_Logic.Services
{
    /// <summary>
    /// Класс служб для работы с новостями
    /// </summary>
    public class NewsServices : INewsService
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
        /// Создание службы по классу работы с репозиториями
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="mapper"></param>
        public NewsServices(IUnitOfWork entity, IMapper mapper)
        {
            _db = entity;
            _mapper = mapper;
        }

        /// <summary>
        /// Метод получения новости по Id
        /// </summary>
        /// <param name="id">
        /// Id новости
        /// </param>
        /// <remarks>
        /// Происходит проецирование модели News на NewsDetailDTO
        /// </remarks>
        /// <returns>
        /// Возвращает новость по ее id
        /// </returns>
        public NewsMainDto GetNews(Guid id)
        {
            var news = _db.NewsRep.Get(id);
            return _mapper.Map<NewsMainDto>(news);
        }

        /// <summary>
        /// Метод получения всех новостей
        /// </summary>
        /// <remarks>
        /// проецирование модели News на NewsShortDTO
        /// </remarks>
        /// <returns>
        /// Возвращает все новости в коротком формате
        /// </returns>
        public IEnumerable<NewsShortDto> GetAllNews()
        {
            var news = _db.NewsRep.GetAll()
                .OrderByDescending(news => news.CreationDateTime);

            return _mapper.Map<IEnumerable<News>, IEnumerable<NewsShortDto>>(news);
        }

        /// <summary>
        /// Метод получения группы новостей
        /// </summary>
        /// <returns>Возвращает 4 новости</returns>
        public IEnumerable<NewsShortDto> GetGroupNews(int page)
        {
            var news = _db.NewsRep.GetAll()
                .OrderByDescending(s => s.CreationDateTime)
                .Skip(page * 10)
                .Take(10);

            return _mapper.Map<IEnumerable<News>, IEnumerable<NewsShortDto>>(news);
        }

        /// <summary>
        /// Добавляет запись в бд
        /// </summary>
        /// <param name="news">Новость</param>
        public void Add(NewsDetailDto news)
        {
            News _news = _mapper.Map<News>(news);
            _news.Id = new Guid();
            _news.CreationDateTime = DateTime.Now;
            _news.ChangingDateTime = DateTime.Now;
            _db.NewsRep.Add(_news);
            _db.Save();
        }
        /// <summary>
        /// Изменяет уже имеющуюся новость
        /// </summary>
        /// <param name="news"></param>
        public void Update(NewsDetailDto news)
        {
            News _news = _mapper.Map<News>(news);
            _db.NewsRep.Update(_news);
            _db.Save();
        }
        /// <summary>
        /// Удаление новости по идентификатору
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            _db.NewsRep.Delete(id);
        }
    }
}
