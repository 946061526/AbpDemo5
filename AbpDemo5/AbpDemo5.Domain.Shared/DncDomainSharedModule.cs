using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace AbpDemo5.Domain.Shared
{
    [DependsOn(typeof(AbpIdentityDomainSharedModule))]
    public class AbpDemoDomainSharedModule : AbpModule
    {

    }
}