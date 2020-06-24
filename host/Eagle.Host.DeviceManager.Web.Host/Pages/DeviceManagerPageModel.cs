using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Eagle.Host.DeviceManager.Pages
{
    public abstract class DeviceManagerPageModel : AbpPageModel
    {
        protected DeviceManagerPageModel()
        {
            LocalizationResourceType = typeof(DeviceManagerResource);
        }
    }
}