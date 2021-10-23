using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ModuleA
{
    [DependsOn(
        typeof(ModuleADomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ModuleAApplicationContractsModule : AbpModule
    {

    }
}
