using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpDemo5.Tools.Base.Paged
{
    public interface IPagedList<T> : IListResult<T>, IHasTotalCount
    {
    }
}
