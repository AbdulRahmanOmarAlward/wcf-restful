using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFRestFull.Core.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        WCFRestfulContext dbContext;

        public WCFRestfulContext Init()
        {
            return dbContext ?? (dbContext = new WCFRestfulContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
