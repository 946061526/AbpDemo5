using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AbpDemo5.Tools.Base;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using static AbpDemo5.Domain.Shared.AbpDemoConsts;

namespace AbpDemo5.HttpApi.Controllers
{
    [ApiController]
    [Route("/auth/v1")]
    [ApiExplorerSettings(GroupName = Grouping.GroupName_User_V2)]
    public class AuthController : AbpController
    {
        //private readonly IAuthorizeService _authorizeService;

        //public AuthController(IAuthorizeService authorizeService)
        //{
        //    _authorizeService = authorizeService;
        //}

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpGet("get_token")]
        public async Task<ApiResult<string>> GetAccessTokenAsync(string code)
        {
            return await Task.Run(() =>
            {
                return new ApiResult<string>();
            });
        }

        /// <summary>
        /// 验证Token是否合法
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet("verify_token")]
        [Authorize]
        public async Task<ApiResult> VerifyToken(string token)
        {
            return await Task.Run(() =>
            {
                return new ApiResult<string>();
            });
        }
    }
}