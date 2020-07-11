using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.DTO
{
    public class NewsDetailDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string NewsImage { get; set; }
        public string MainText { get; set; }
        public DateTime CreationDataTime { get; set; }
        public DateTime ChangingDataTime { get; set; }
        public bool Relevancy { get; set; }

    }
}
