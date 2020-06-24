using Volo.Abp.Modularity;

namespace Eagle.Host.DeviceManager
{
    [DependsOn(
        typeof(DeviceManagerApplicationModule),
        typeof(DeviceManagerDomainTestModule)
        )]
    public class DeviceManagerApplicationTestModule : AbpModule
    {

    }
}
