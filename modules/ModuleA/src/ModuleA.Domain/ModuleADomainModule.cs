using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ModuleA
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ModuleADomainSharedModule)
    )]
    public class ModuleADomainModule : AbpModule
    {

    }
}
