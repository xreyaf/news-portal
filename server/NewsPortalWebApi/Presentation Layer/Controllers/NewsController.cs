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
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        readonly INewsService<NewsDetailDto> newsService;
        private readonly IUnitOfWork _unitOfWork;
        public NewsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            newsService = new NewsServices(_unitOfWork);
        }
        [HttpGet]
        public IEnumerable<NewsDetailDto> GetAllNews()
        {
            return newsService.GetAllNews();
        }
        [HttpGet("{id}")]
        public NewsDetailDto GetNews(Guid Id)
        {
            return newsService.GetNews(Id);
        }
    }
}
