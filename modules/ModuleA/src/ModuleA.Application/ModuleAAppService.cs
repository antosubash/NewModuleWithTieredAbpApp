using ModuleA.Localization;
using Volo.Abp.Application.Services;

namespace ModuleA
{
    public abstract class ModuleAAppService : ApplicationService
    { 
        protected ModuleAAppService()
        {
            LocalizationResource = typeof(ModuleAResource);
            ObjectMapperContext = typeof(ModuleAApplicationModule);
        }
    }
}
