using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace ModuleA
{
    [DependsOn(
        typeof(ModuleAApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ModuleAHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ModuleA";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ModuleAApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
