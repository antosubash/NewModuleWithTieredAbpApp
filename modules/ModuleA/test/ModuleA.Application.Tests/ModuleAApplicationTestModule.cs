using Volo.Abp.Modularity;

namespace ModuleA
{
    [DependsOn(
        typeof(ModuleAApplicationModule),
        typeof(ModuleADomainTestModule)
        )]
    public class ModuleAApplicationTestModule : AbpModule
    {

    }
}
