using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace ModuleA.Web.Menus
{
    public class ModuleAMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(ModuleAMenus.Prefix, displayName: "ModuleA", "~/ModuleA", icon: "fa fa-globe"));

            return Task.CompletedTask;
        }
    }
}