using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.Inerfaces
{
    public interface INewsService<T> where T : class
    {
        T GetNews(Guid Id);
        IEnumerable<T> GetAllNews();
    }
}
