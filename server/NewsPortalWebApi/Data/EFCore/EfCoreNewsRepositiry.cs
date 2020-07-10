using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortalWebApi.Data.EFCore
{
    public class EfCoreNewsRepository : EfCoreRepository<News, NewsPortalWebApiContext>
    {
        public EfCoreNewsRepository(NewsPortalWebApiContext context) : base(context)
        {

        }
    }
}
