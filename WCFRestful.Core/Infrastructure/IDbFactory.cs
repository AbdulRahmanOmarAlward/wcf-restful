using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFRestFull.Core.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        WCFRestfulContext Init();
    }
}
