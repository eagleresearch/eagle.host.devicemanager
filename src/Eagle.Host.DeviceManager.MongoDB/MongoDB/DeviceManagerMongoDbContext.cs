using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Eagle.Host.DeviceManager.MongoDB
{
    [ConnectionStringName(DeviceManagerDbProperties.ConnectionStringName)]
    public class DeviceManagerMongoDbContext : AbpMongoDbContext, IDeviceManagerMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureDeviceManager();
        }
    }
}