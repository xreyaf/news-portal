using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Data;

namespace NewsPortalWebApi
{
    public class News : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }       
        public string NewsImage { get; set; }
    }
}
