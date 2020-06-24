using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.Application.Services;

namespace Eagle.Host.DeviceManager
{
    public abstract class DeviceManagerAppService : ApplicationService
    {
        protected DeviceManagerAppService()
        {
            LocalizationResource = typeof(DeviceManagerResource);
            ObjectMapperContext = typeof(DeviceManagerApplicationModule);
        }
    }
}
