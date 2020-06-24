using Eagle.Host.DeviceManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Eagle.Host.DeviceManager
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(DeviceManagerEntityFrameworkCoreTestModule)
        )]
    public class DeviceManagerDomainTestModule : AbpModule
    {
        
    }
}
