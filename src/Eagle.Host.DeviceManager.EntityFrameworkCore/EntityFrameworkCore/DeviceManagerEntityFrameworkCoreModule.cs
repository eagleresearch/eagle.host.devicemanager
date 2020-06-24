using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Eagle.Host.DeviceManager.EntityFrameworkCore
{
    [DependsOn(
        typeof(DeviceManagerDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class DeviceManagerEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DeviceManagerDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddDefaultRepositories<IDeviceManagerDbContext>();
            });
        }
    }
}