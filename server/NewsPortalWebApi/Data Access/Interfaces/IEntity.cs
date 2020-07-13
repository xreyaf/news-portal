using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Data_Access.Interfaces
{
    /// <summary>
    /// Интерфейс для сущности
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Свойство идентификатора сущности
        /// </summary>
        public Guid Id { get; set; }
    }
}
