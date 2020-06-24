using Eagle.Host.DeviceManager.Localization;
using Eagle.Host.DeviceManager.Web.Menus;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;

namespace Eagle.Host.DeviceManager.Web
{
    [DependsOn(
        typeof(DeviceManagerHttpApiModule),
        typeof(AbpAspNetCoreMvcUiThemeSharedModule),
        typeof(AbpAutoMapperModule)
        )]
    public class DeviceManagerWebModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
            {
                options.AddAssemblyResource(typeof(DeviceManagerResource), typeof(DeviceManagerWebModule).Assembly);
            });

            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(DeviceManagerWebModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new DeviceManagerMenuContributor());
            });

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<DeviceManagerWebModule>("Eagle.Host.DeviceManager.Web");
            });

            context.Services.AddAutoMapperObjectMapper<DeviceManagerWebModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<DeviceManagerWebModule>();
            });

            Configure<RazorPagesOptions>(options =>
            {
                //Configure authorization.
            });

            ConfigureAutoApiControllers();
        }

        private void ConfigureAutoApiControllers()
        {
            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers.Create(typeof(DeviceManagerApplicationModule).Assembly);
            });
        }
    }
}
