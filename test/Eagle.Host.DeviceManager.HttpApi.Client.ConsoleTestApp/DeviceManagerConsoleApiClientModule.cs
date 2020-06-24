using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Eagle.Host.DeviceManager
{
    [DependsOn(
        typeof(DeviceManagerHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DeviceManagerConsoleApiClientModule : AbpModule
    {
        
    }
}
