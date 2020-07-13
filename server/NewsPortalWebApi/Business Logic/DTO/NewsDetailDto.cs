﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.DTO
{
    /// <summary>
    /// Класс передачи данных новости
    /// </summary>
    public class NewsDetailDto
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
        public string MainText { get; set; }
        /// <summary>
        /// Свойство актуальности новости
        /// </summary>
        public bool Relevancy { get; set; }
        /// <summary>
        /// Свойство даты создания статьи
        /// </summary>
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// Свойство даты изменения новости
        /// </summary>
        public DateTime ChangingDateTime { get; set; }

    }
}
