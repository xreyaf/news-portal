using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Business_Logic.Inerfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface INewsService<out T> where T : class
    {
        T GetNews(Guid id);
        IEnumerable<T> GetAllNews();
    }
}
