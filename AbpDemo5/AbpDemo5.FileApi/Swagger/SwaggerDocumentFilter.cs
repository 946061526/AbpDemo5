using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AbpDemo5.FileApi.Swagger
{
    /// <summary>
    /// 对应Controller的API文档描述信息
    /// </summary>
    public class SwaggerDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var tags = new List<OpenApiTag>
            {
                new OpenApiTag {
                    Name = "File",
                    Description = "文件相关接口",
                    ExternalDocs = new OpenApiExternalDocs { Description = "包含：文件/分类" }
                }
            };

            #region 实现添加自定义描述时过滤不属于同一个分组的API

            try
            {
                // 当前分组名称
                var groupName = context.ApiDescriptions.FirstOrDefault().GroupName;

                // 当前所有的API对象
                var apis = context.ApiDescriptions.GetType().GetField("_source", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(context.ApiDescriptions) as IEnumerable<ApiDescription>;

                // 不属于当前分组的所有Controller
                // 注意：配置的OpenApiTag，Name名称要与Controller的Name对应才会生效。
                var controllers = apis.Where(x => x.GroupName != groupName).Select(x => ((ControllerActionDescriptor)x.ActionDescriptor).ControllerName).Distinct();

                // 筛选一下tags
                swaggerDoc.Tags = tags.Where(x => !controllers.Contains(x.Name)).OrderBy(x => x.Name).ToList();
            }
            catch { }

            #endregion
        }
    }
}