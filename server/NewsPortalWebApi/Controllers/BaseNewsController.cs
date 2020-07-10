using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortalWebApi.Data;

namespace NewsPortalWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseNewsController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseNewsController(TRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/News
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetNews()
        {
            return await repository.GetAll();
        }

        // GET: api/News/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetNews(Guid id)
        {
            var news = await repository.Get(id);
            if (news == null)
            {
                return NotFound();
            }
            return news;
        }

        // PUT: api/News/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNews(Guid id, TEntity news)
        {
            if (id != news.Id)
            {
                return BadRequest();
            }
            await repository.Update(news);
            return NoContent();
        }

        // POST: api/News
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity news)
        {
            await repository.Add(news);
            return CreatedAtAction("Get", new { id = news.Id }, news);
        }

        // DELETE: api/News/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(Guid id)
        {
            var news = await repository.Delete(id);
            if (news == null)
            {
                return NotFound();
            }
            return news;
        }
    }
}
