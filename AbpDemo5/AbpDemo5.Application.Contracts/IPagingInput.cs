using System.ComponentModel.DataAnnotations;

namespace AbpDemo5.Application.Contracts
{
    /// <summary>
    /// 分页输入参数
    /// </summary>
    public interface IPagingInput
    {
        /// <summary>
        /// 页码
        /// </summary>
        [Range(1, int.MaxValue)]
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [Range(1, 100)]
        public int PageSize { get; set; }
    }
}