using ModuleA.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ModuleA.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ModuleAPageModel : AbpPageModel
    {
        protected ModuleAPageModel()
        {
            LocalizationResourceType = typeof(ModuleAResource);
            ObjectMapperContext = typeof(ModuleAWebModule);
        }
    }
}