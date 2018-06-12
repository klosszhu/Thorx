using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thorx.MongoResponsitory;

namespace Thorx.Web.Extention
{
    public interface IBaseController<T>
    {
        AbstractResponsitory<T> 
    }
}
