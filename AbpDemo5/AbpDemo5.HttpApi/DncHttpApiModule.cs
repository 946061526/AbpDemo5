using AbpDemo5.Application;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace AbpDemo5.HttpApi
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpDemoApplicationModule)
    )]
    public class AbpDemoHttpApiModule : AbpModule
    {

    }
}