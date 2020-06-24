using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Uow;

namespace Eagle.Host.DeviceManager.Seed
{
    public class DeviceManagerUnifiedDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly DeviceManagerSampleIdentityDataSeeder _sampleIdentityDataSeeder;
        private readonly DeviceManagerSampleDataSeeder _deviceManagerSampleDataSeeder;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public DeviceManagerUnifiedDataSeedContributor(
            DeviceManagerSampleIdentityDataSeeder sampleIdentityDataSeeder,
            IUnitOfWorkManager unitOfWorkManager, 
            DeviceManagerSampleDataSeeder deviceManagerSampleDataSeeder)
        {
            _sampleIdentityDataSeeder = sampleIdentityDataSeeder;
            _unitOfWorkManager = unitOfWorkManager;
            _deviceManagerSampleDataSeeder = deviceManagerSampleDataSeeder;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await _unitOfWorkManager.Current.SaveChangesAsync();
            await _sampleIdentityDataSeeder.SeedAsync(context);
            await _unitOfWorkManager.Current.SaveChangesAsync();
            await _deviceManagerSampleDataSeeder.SeedAsync(context);
        }
    }
}