using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Eagle.Host.DeviceManager.Seed
{
    /* You can use this file to seed some sample data
     * to test your module easier.
     *
     * This class is shared among these projects:
     * - Eagle.Host.DeviceManager.IdentityServer
     * - Eagle.Host.DeviceManager.Web.Unified (used as linked file)
     */
    public class DeviceManagerSampleDataSeeder : ITransientDependency
    {
        public async Task SeedAsync(DataSeedContext context)
        {
            
        }
    }
}
