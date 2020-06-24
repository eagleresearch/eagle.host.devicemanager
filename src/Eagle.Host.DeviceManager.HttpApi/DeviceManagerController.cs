using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Eagle.Host.DeviceManager
{
    public abstract class DeviceManagerController : AbpController
    {
        protected DeviceManagerController()
        {
            LocalizationResource = typeof(DeviceManagerResource);
        }
    }
}
