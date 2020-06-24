using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Eagle.Host.DeviceManager.Pages
{
    public abstract class DeviceManagerPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<DeviceManagerResource> L { get; set; }
    }
}
