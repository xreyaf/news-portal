using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.DTO
{
    /// <summary>
    /// DTO с полной информацией о новости
    /// </summary>
    public class NewsDetailDto
    {
        /// <summary>
        /// Идентификатор новости
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название статьи
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Свойство краткого описания статьи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Свойство основного текста новости
        /// </summary>
        public string MainText { get; set; }
        /// <summary>
        /// Свойство изображения новости
        /// </summary>
        public byte[] NewsImage { get; set; }
        /// <summary>
        /// Дата создания статьи
        /// </summary>
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// имя автора
        /// </summary>
        public string AuthorName { get; set; }
    }
}
