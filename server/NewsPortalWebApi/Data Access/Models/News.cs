using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Data_Access.Interfaces;


namespace NewsPortalWebApi.Data_Access.Models
{
    /// <summary>
    /// Этот класс содержит основные свойства новостей
    /// </summary>
    public class News : IEntity
    {
        /// <summary>
        /// идентификатор новости
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// название статьи
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// краткое описание статьи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// изображение новости
        /// </summary>
        public byte[] NewsImage { get; set; }
        /// <summary>
        /// основной текст новости
        /// </summary>
        public string MainText { get; set; }
        /// <summary>
        /// актуальность новости
        /// </summary>
        public bool Relevancy { get; set; }
        /// <summary>
        /// дата создания статьи
        /// </summary>
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// дата изменения новости
        /// </summary>
        public DateTime ChangingDateTime { get; set; }
        /// <summary>
        /// автор статьи
        /// </summary>
        public Author Author { get; set; }
    }
}
