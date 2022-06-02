using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpDemo5.Application.Contracts.File.InputParams
{
    /// <summary>
    /// 查询文件入参
    /// </summary>
    public class QueryFileInput : IPagingInput
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
