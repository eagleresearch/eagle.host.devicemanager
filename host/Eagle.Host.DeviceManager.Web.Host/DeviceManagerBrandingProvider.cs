using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Eagle.Host.DeviceManager
{
    [Dependency(ReplaceServices = true)]
    public class DeviceManagerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DeviceManager";
    }
}
