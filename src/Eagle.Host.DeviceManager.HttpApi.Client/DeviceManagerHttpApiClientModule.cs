using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Eagle.Host.DeviceManager
{
    [DependsOn(
        typeof(DeviceManagerApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class DeviceManagerHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "DeviceManager";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(DeviceManagerApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
