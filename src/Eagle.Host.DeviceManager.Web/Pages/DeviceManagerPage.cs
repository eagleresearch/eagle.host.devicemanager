using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Eagle.Host.DeviceManager.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Eagle.Host.DeviceManager.Web.Pages.DeviceManagerPage
     */
    public abstract class DeviceManagerPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<DeviceManagerResource> L { get; set; }
    }
}
