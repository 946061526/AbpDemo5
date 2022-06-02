namespace AbpDemo5.Tools.Base
{
    /// <summary>
    /// 响应实体
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// 响应码
        /// </summary>
        public ApiResultCode Code { get; set; } = ApiResultCode.Failed;

        /// <summary>
        /// 响应信息
        /// </summary>
        public string Message { get; set; }

        public ApiResult(ApiResultCode Code = ApiResultCode.Succeed, string message = "")
        {
            this.Code = Code;
            this.Message = message;
        }

        /// <summary>
        /// 响应成功
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public void IsSuccess(string message = "")
        {
            Message = message;
            Code = ApiResultCode.Succeed;
        }

        /// <summary>
        /// 响应失败
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public void IsFailed(string message = "")
        {
            Message = message;
            Code = ApiResultCode.Failed;
        }

        /// <summary>
        /// 认证失败
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public void NotAuthorized(string message = "")
        {
            Message = message;
            Code = ApiResultCode.NotAuthorized;
        }
    }
}
