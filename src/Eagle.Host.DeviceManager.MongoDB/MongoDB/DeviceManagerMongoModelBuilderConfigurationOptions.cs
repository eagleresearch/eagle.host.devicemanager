using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Eagle.Host.DeviceManager.MongoDB
{
    public class DeviceManagerMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public DeviceManagerMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}