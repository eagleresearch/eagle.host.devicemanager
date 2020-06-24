using Eagle.Host.DeviceManager.Localization;
using Eagle.Host.DeviceManager.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Eagle.Host.DeviceManager.Web.Menus
{
    public class DeviceManagerMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            var localizer = context.GetLocalizer<DeviceManagerResource>();

            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context, localizer);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context, IStringLocalizer localizer)
        {
            var authorizationService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();

            var deviceMangerMenu = new ApplicationMenuItem("DeviceManager", localizer["Menu:DeviceManager"], icon: "fa fa-server");

            if (await authorizationService.IsGrantedAsync(DeviceManagerPermissions.Devices.Default))
            {
                deviceMangerMenu.AddItem(new ApplicationMenuItem("DeviceManager.Devices", localizer["Menu:DeviceManager:Devices"], url: "/Devices", icon: "fa fa-hdd"));
            }

            if (deviceMangerMenu.Items.Count > 0)
            {
                context.Menu.AddItem(deviceMangerMenu);
            }
        }
    }
}