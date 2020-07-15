using NewsPortalWebApi.Data_Access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Data_Access.Models
{
    /// <summary>
    /// основные свойства авторов
    /// </summary>
    public class Author : IEntity
    {
        /// <summary>
        /// id автора
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Список новостей данного автора
        /// </summary>
        public List<News> News { get; set; }
    }
}
