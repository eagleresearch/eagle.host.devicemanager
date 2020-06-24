using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Eagle.Host.DeviceManager.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DeviceManagerPageModel : AbpPageModel
    {
        protected DeviceManagerPageModel()
        {
            LocalizationResourceType = typeof(DeviceManagerResource);
            ObjectMapperContext = typeof(DeviceManagerWebModule);
        }
    }
}