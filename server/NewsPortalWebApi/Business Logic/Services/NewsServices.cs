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
    public class NewsServices : INewsService<NewsDetailDto>
    {
        private readonly IUnitOfWork _db;

        public NewsServices(IUnitOfWork entity)
        {
            _db = entity;
        }
        public NewsDetailDto GetNews(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsDetailDto>()).CreateMapper();
            return mapper.Map<News, NewsDetailDto>(_db.NewsRep.Get(id));
        }
        public IEnumerable<NewsDetailDto> GetAllNews()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsDetailDto>()).CreateMapper();
            return mapper.Map<IEnumerable<News>, List<NewsDetailDto>>(_db.NewsRep.GetAll());
        }
    }
}
