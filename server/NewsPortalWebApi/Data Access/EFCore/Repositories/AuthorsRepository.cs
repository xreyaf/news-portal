using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsPortalWebApi.Data_Access.Interfaces;
using NewsPortalWebApi.Data_Access.Models;


namespace NewsPortalWebApi.Data_Access.EFCore.Repositories
{
    /// <summary>
    /// Класс репозитория авторов
    /// </summary>
    public class AuthorsRepository : IRepository<Author>
    {
        private readonly NewsPortalWebApiContext _context;

        /// <summary>
        /// Констурктор репозитория
        /// </summary>
        /// <param name="context">
        /// Аргументом является контекст из базы данных
        /// </param>
        public AuthorsRepository(NewsPortalWebApiContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Метод для получения всех авторов
        /// </summary>
        /// <returns>
        /// Возвращает всех авторов из базы данных
        /// </returns>
        public IEnumerable<Author> GetAll()
        {
            return _context.Authors;
        }
        /// <summary>
        /// Метод для получения автора по id
        /// </summary>
        /// <param name="id">
        /// id нужного автора
        /// </param>
        /// <returns>
        /// Возвращает нужного автора</returns>
        public Author Get(Guid id)
        {
            return _context.Authors.Find(id);
        }
        
        /// <summary>
        /// Добавляет автора в базу данных
        /// </summary>
        /// <param name="entity">
        /// </param>
        public void Add(Author entity)
        {
            _context.Add(entity);
        }
        /// <summary>
        /// Удаляет автора по id
        /// </summary>
        /// <param name="id">
        /// id автора
        /// </param>
        public void Delete(Guid id)
        {
            Author entity = _context.Authors.Find(id);
            if (entity != null)
                _context.Authors.Remove(entity);
        }
        /// <summary>
        /// Изменяет автора
        /// </summary>
        /// <param name="entity"></param>
        public void Update(Author entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
