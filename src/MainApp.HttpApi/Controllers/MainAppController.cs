using MainApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MainApp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MainAppController : AbpController
    {
        protected MainAppController()
        {
            LocalizationResource = typeof(MainAppResource);
        }
    }
}