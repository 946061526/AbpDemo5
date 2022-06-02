using AbpDemo5.Domain.Shared;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace AbpDemo5.Domain
{
    [DependsOn(
        typeof(AbpIdentityDomainModule),
        typeof(AbpDemoDomainSharedModule)
    )]
    public class AbpDemoDomainModule : AbpModule
    {

    }
}