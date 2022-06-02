using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpDemo5.Tools.Base
{
    /// <summary>
    /// 响应实体(泛型)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResult<T> : ApiResult where T : class
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 响应成功
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        public void IsSuccess(T data = null, string message = "")
        {
            Message = message;
            Code = ApiResultCode.Succeed;
            Data = data;
        }
    }
}
