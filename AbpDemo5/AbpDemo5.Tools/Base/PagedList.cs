using AbpDemo5.Tools.Base.Paged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpDemo5.Tools.Base
{
    /// <summary>
    /// 分页响应实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedList<T> : ListResult<T>, IPagedList<T>
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int Total { get; set; }

        public PagedList()
        {
        }

        public PagedList(int total, IReadOnlyList<T> result) : base(result)
        {
            Total = total;
        }
    }
}
