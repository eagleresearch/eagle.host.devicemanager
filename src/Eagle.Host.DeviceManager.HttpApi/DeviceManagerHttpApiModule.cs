using Localization.Resources.AbpUi;
using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Eagle.Host.DeviceManager
{
    [DependsOn(
        typeof(DeviceManagerApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class DeviceManagerHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(DeviceManagerHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<DeviceManagerResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
