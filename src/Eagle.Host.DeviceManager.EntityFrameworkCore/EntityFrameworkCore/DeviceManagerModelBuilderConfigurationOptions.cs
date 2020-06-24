using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Eagle.Host.DeviceManager.EntityFrameworkCore
{
    public class DeviceManagerModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public DeviceManagerModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}