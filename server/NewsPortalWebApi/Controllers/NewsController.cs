using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsPortalWebApi;
using NewsPortalWebApi.Data;
using NewsPortalWebApi.Data.EFCore;

namespace NewsPortalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : BaseNewsController<News, EfCoreNewsRepository>
    {
        //private readonly NewsPortalWebApiContext _context;

        public NewsController(EfCoreNewsRepository repository) : base(repository)
        {
            
        }

        /*private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.Id == id);
        }*/
    }
}
