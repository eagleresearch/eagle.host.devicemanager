using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Eagle.Host.DeviceManager
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class DeviceManagerDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<DeviceManagerDomainSharedModule>("Eagle.Host.DeviceManager");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<DeviceManagerResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/DeviceManager");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("DeviceManager", typeof(DeviceManagerResource));
            });
        }
    }
}
