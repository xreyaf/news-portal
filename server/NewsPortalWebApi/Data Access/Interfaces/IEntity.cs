using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Data_Access.Interfaces
{
    /// <summary>
    /// сущность
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// идентификатор сущности
        /// </summary>
        public Guid Id { get; set; }
    }
}
