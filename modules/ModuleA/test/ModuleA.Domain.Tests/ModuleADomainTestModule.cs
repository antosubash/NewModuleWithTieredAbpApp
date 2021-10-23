using ModuleA.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ModuleA
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ModuleAEntityFrameworkCoreTestModule)
        )]
    public class ModuleADomainTestModule : AbpModule
    {
        
    }
}
