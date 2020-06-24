using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Eagle.Host.DeviceManager.MongoDB
{
    [ConnectionStringName(DeviceManagerDbProperties.ConnectionStringName)]
    public interface IDeviceManagerMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
