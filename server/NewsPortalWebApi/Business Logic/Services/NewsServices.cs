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
        IUnitOfWork Db { get; set; }

        public NewsServices(IUnitOfWork entity)
        {
            Db = entity;
        }
        public NewsDetailDto GetNews(Guid Id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsDetailDto>()).CreateMapper();
            return mapper.Map<News, NewsDetailDto>(Db.NewsRep.Get(Id));
        }
        public IEnumerable<NewsDetailDto> GetAllNews()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsDetailDto>()).CreateMapper();
            return mapper.Map<IEnumerable<News>, List<NewsDetailDto>>(Db.NewsRep.GetAll());
        }
    }
}
