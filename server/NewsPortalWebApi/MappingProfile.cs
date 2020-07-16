using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NewsPortalWebApi.Business_Logic.DTO;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Business_Logic
{
    /// <summary>
    /// Класс в котором содержится мапинг DTO
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Конструктор профиля Mapper
        /// </summary>
        public MappingProfile()
        {
            CreateMap<News, NewsShortDto>()
                .ForMember("AuthorName",
                    opt => opt.MapFrom(c => c.Author.Name));
            CreateMap<News, NewsDetailDto>();
            CreateMap<Author, AuthorDto>();
        }
    }
}
