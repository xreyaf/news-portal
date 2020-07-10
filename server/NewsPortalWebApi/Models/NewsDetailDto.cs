using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Models
{
    public class NewsDetailDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] NewsImage { get; set; }
        public string MainText { get; set; }
        public DateTime CreationDataTime { get; set; }
        public DateTime ChengingDataTime { get; set; }
    }
}
