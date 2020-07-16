using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Business_Logic.DTO
{
    /// <summary>
    /// DTO с укороченной информацией о новости
    /// </summary>
    public class NewsShortDto
    {
        /// <summary>
        /// Идентификатор новости
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Свойство названия статьи
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Свойство краткого описания статьи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Свойство изображения новости
        /// </summary>
        public byte[] NewsImage { get; set; }
        /// <summary>
        /// Дата создания статьи
        /// </summary>
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        public Author Author { get; set; }
        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public Guid AuthorId { get; set; }
    }
}
