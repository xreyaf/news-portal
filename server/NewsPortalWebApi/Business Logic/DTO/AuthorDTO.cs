﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Business_Logic.DTO
{
    /// <summary>
    /// DTO с информацией об авторе без списка принадлежащих им новостей
    /// </summary>
    public class AuthorDTO
    {
        /// <summary>
        /// id автора
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        public string Name { get; set; }
    }
}
