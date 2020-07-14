using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Data_Access.Interfaces;


namespace NewsPortalWebApi.Data_Access.Models
{
    public class News : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        /*В столбце NewsImage содержатся пути к картинкам
        в файловой системе.*/
        public string NewsImage { get; set; }
        public string MainText { get; set; }
        public bool Relevancy { get; set; }
        public DateTime CreationDataTime { get; set; }
        public DateTime ChengingDataTime { get; set; }
    }
}
