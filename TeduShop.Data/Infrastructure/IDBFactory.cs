using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    //dung de khoi tao db
    public interface IDbFactory:IDisposable
    {
        TeduShopDbContext Init();
    }
}
