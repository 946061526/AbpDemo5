using AbpDemo5.Domain.Configurations;
using AbpDemo5.Swagger.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.IO;
using static AbpDemo5.Domain.Shared.AbpDemoConsts;

namespace AbpDemo5.Swagger
{
    public static class DemoSwaggerExtensions
    {
        /// <summary>
        /// 当前API版本，从appsettings.json获取
        /// </summary>
        private static readonly string version = $"v{AppSettings.ApiVersion}";

        /// <summary>
        /// Swagger描述信息
        /// </summary>
        private static readonly string description = "AbpDemo管理系统后台接口";

        /// <summary>
        /// Swagger分组信息，将进行遍历使用
        /// </summary>
        private static readonly List<SwaggerApiInfo> ApiInfos = new List<SwaggerApiInfo>()
        {
            new SwaggerApiInfo
            {
                UrlPrefix = Grouping.GroupName_User_V1,
                Name = "AbpDemo 用户相关接口",
                OpenApiInfo = new OpenApiInfo
                {
                    Version = version,
                    Title = "AbpDemoManage - 用户相关接口",
                    Description = description
                }
            },
            new SwaggerApiInfo
            {
                UrlPrefix = Grouping.GroupName_Files_V1,
                Name = "AbpDemo 文件相关接口",
                OpenApiInfo = new OpenApiInfo
                {
                    Version = version,
                    Title = "AbpDemoManage - 文件相关接口",
                    Description = description
                }
            },
            //new SwaggerApiInfo
            //{
            //    UrlPrefix = Grouping.GroupName_v1,
            //    Name = "AbpDemo后台接口",
            //    OpenApiInfo = new OpenApiInfo
            //    {
            //        Version = version,
            //        Title = "AbpDemoManage - 业务相关接口",
            //        Description = description
            //    }
            //},
            //new SwaggerApiInfo
            //{
            //    UrlPrefix = Grouping.GroupName_v2,
            //    Name = "JWT授权接口",
            //    OpenApiInfo = new OpenApiInfo
            //    {
            //        Version = version,
            //        Title = "AbpDemoManage - JWT授权接口",
            //        Description = description
            //    }
            //}
        };

        /// <summary>
        /// AddSwagger
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddMvc();
            return services.AddSwaggerGen(options =>
            {
                // 遍历并应用Swagger分组信息
                ApiInfos.ForEach(x =>
                {
                    options.SwaggerDoc(x.UrlPrefix, x.OpenApiInfo);
                });

                var xmlPath = Path.Combine(AppContext.BaseDirectory, "Resources/AbpDemo5.UserApi.xml");
                if (File.Exists(xmlPath))
                {
                    options.IncludeXmlComments(xmlPath);
                }

                xmlPath = Path.Combine(AppContext.BaseDirectory, "Resources/AbpDemo5.FileApi.xml");
                if (File.Exists(xmlPath))
                {
                    options.IncludeXmlComments(xmlPath);
                }

                //options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Resources/AbpDemo5.HttpApi.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Resources/AbpDemo5.Domain.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Resources/AbpDemo5.Application.Contracts.xml"));

                #region 小绿锁，JWT身份认证配置

                var security = new OpenApiSecurityScheme
                {
                    Description = "JWT模式授权，请输入 Bearer {Token} 进行身份验证",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                };
                options.AddSecurityDefinition("oauth2", security);
                options.AddSecurityRequirement(new OpenApiSecurityRequirement { { security, new List<string>() } });
                options.OperationFilter<AddResponseHeadersFilter>();
                options.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                options.OperationFilter<SecurityRequirementsOperationFilter>();

                #endregion

                // 应用Controller的API文档描述信息
                options.DocumentFilter<SwaggerDocumentFilter>();
            });
        }

        /// <summary>
        /// UseSwaggerUI
        /// </summary>
        /// <param name="app"></param>
        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwaggerUI(options =>
            {
                // 遍历分组信息，生成Json
                ApiInfos.ForEach(x =>
                {
                    options.SwaggerEndpoint($"/swagger/{x.UrlPrefix}/swagger.json", x.Name);
                });

                // 模型的默认扩展深度，设置为 -1 完全隐藏模型
                options.DefaultModelsExpandDepth(-1);
                // API文档仅展开标记
                options.DocExpansion(DocExpansion.List);
                // API前缀设置为空
                options.RoutePrefix = string.Empty;
                // API页面Title
                options.DocumentTitle = "接口文档 - AbpDemoManage";
            });
        }

        internal class SwaggerApiInfo
        {
            /// <summary>
            /// URL前缀
            /// </summary>
            public string UrlPrefix { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// <see cref="Microsoft.OpenApi.Models.OpenApiInfo"/>
            /// </summary>
            public OpenApiInfo OpenApiInfo { get; set; }
        }
    }
}