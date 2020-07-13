using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsPortalWebApi.Data_Access.Models;

namespace NewsPortalWebApi.Data_Access.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<News> NewsRep { get; }
        void Save();
    }
}
