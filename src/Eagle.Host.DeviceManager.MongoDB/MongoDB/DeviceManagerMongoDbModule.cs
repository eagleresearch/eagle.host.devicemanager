using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Eagle.Host.DeviceManager.MongoDB
{
    [DependsOn(
        typeof(DeviceManagerDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class DeviceManagerMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<DeviceManagerMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
