using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using static AbpDemo5.Domain.Shared.AbpDemoConsts;

namespace AbpDemo5.FileApi.Controllers
{
    /// <summary>
    /// 文件相关接口
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = Grouping.GroupName_Files_V1)]
    public class FilesController : AbpController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FilesController> _logger;

        public FilesController(ILogger<FilesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get")]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "f1", "f2" };
        }

        [HttpDelete("delete")]
        public IEnumerable<string> Delete()
        {
            throw new NotImplementedException("delete error");
        }
    }
}
