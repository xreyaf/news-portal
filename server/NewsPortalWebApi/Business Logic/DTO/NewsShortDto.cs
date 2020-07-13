using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.DTO
{
    /// <summary>
    /// Измененный класс передачи данных
    /// </summary>
    public class NewsShortDto
    {
        /// <summary>
        /// Свойство идентификатора новости
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
        /// Свойство основного текста новости
        /// </summary>
        
    }
}
