using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Eagle.Host.DeviceManager.Seed
{
    public class DeviceManagerIdentityServerDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly DeviceManagerSampleIdentityDataSeeder _deviceManagerSampleIdentityDataSeeder;
        private readonly DeviceManagerIdentityServerDataSeeder _deviceManagerIdentityServerDataSeeder;

        public DeviceManagerIdentityServerDataSeedContributor(
            DeviceManagerIdentityServerDataSeeder deviceManagerIdentityServerDataSeeder,
            DeviceManagerSampleIdentityDataSeeder deviceManagerSampleIdentityDataSeeder)
        {
            _deviceManagerIdentityServerDataSeeder = deviceManagerIdentityServerDataSeeder;
            _deviceManagerSampleIdentityDataSeeder = deviceManagerSampleIdentityDataSeeder;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await _deviceManagerSampleIdentityDataSeeder.SeedAsync(context);
            await _deviceManagerIdentityServerDataSeeder.SeedAsync(context);
        }
    }
}
