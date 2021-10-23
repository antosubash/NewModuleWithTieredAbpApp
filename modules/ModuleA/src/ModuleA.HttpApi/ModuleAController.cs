using ModuleA.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ModuleA
{
    public abstract class ModuleAController : AbpController
    {
        protected ModuleAController()
        {
            LocalizationResource = typeof(ModuleAResource);
        }
    }
}
