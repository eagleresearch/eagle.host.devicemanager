using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Eagle.Host.DeviceManager.Seed
{
    public class DeviceManagerHttpApiHostDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly DeviceManagerSampleDataSeeder _deviceManagerSampleDataSeeder;

        public DeviceManagerHttpApiHostDataSeedContributor(
            DeviceManagerSampleDataSeeder deviceManagerSampleDataSeeder)
        {
            _deviceManagerSampleDataSeeder = deviceManagerSampleDataSeeder;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await _deviceManagerSampleDataSeeder.SeedAsync(context);
        }
    }
}
