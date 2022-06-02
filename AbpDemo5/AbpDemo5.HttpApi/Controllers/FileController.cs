using Microsoft.AspNetCore.Mvc;
using AbpDemo5.Tools.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using static AbpDemo5.Domain.Shared.AbpDemoConsts;

namespace AbpDemo5.HttpApi.Controllers
{
    [ApiController]
    [Route("/file/v1")]
    [ApiExplorerSettings(GroupName = Grouping.GroupName_Files_V1)]
    public class FileController : AbpController
    {
        /// <summary>
        /// 新增文件
        /// </summary>
        /// <returns></returns>
        [HttpGet("add")]
        public async Task<ApiResult<string>> Add()
        {
            return await Task.Run(() =>
            {
                return new ApiResult<string>();
            });
        }


        /// <summary>
        /// 删除文件
        /// </summary>
        /// <returns></returns>
        [HttpDelete("delete")]
        public async Task<ApiResult<string>> Delete()
        {
            throw new NotImplementedException("删除失败");
        }
    }
}
