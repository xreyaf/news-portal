using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.DTO
{
    /// <summary>
    /// DTO с полной информацией об авторе
    /// </summary>
    public class AuthorDetailDTO
    {
        /// <summary>
        /// id автора
        /// /// </summary>
        public Guid Id { get; set; } 
        /// <summary>
        /// Имя автора
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Список новостей данного автора
        /// </summary>
        public ICollection<NewsDetailDto> News { get; set; }
    }
}
