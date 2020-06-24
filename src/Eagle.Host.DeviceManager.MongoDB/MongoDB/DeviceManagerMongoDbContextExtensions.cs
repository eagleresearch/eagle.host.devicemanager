using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Eagle.Host.DeviceManager.MongoDB
{
    public static class DeviceManagerMongoDbContextExtensions
    {
        public static void ConfigureDeviceManager(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DeviceManagerMongoModelBuilderConfigurationOptions(
                DeviceManagerDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}