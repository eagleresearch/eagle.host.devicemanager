using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using IdentityUser = Volo.Abp.Identity.IdentityUser;

namespace Eagle.Host.DeviceManager.Seed
{
    /* Creates a few more sample users to test the application and the module.
     *
     * This class is shared among these projects:
     * - Eagle.Host.DeviceManager.IdentityServer
     * - Eagle.Host.DeviceManager.Web.Unified (used as linked file)
     */
    public class DeviceManagerSampleIdentityDataSeeder : ITransientDependency
    {
        private readonly IIdentityUserRepository _identityUserRepository;
        private readonly ILookupNormalizer _lookupNormalizer;
        private readonly IGuidGenerator _guidGenerator;
        private readonly IdentityUserManager _identityUserManager;

        public DeviceManagerSampleIdentityDataSeeder(
            IIdentityUserRepository identityUserRepository,
            ILookupNormalizer lookupNormalizer,
            IGuidGenerator guidGenerator,
            IdentityUserManager identityUserManager)
        {
            _identityUserRepository = identityUserRepository;
            _lookupNormalizer = lookupNormalizer;
            _guidGenerator = guidGenerator;
            _identityUserManager = identityUserManager;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await CreateUserAsync("john", "John", "Nash", context);
            await CreateUserAsync("albert", "Albert", "Einstein", context);
        }

        private async Task CreateUserAsync(string userName, string name, string surname, DataSeedContext context)
        {
            if ((await _identityUserRepository.FindByNormalizedUserNameAsync(_lookupNormalizer.NormalizeName(userName))) != null)
            {
                return;
            }

            var user = new IdentityUser(
                _guidGenerator.Create(),
                userName,
                userName + "@abp.io",
                context.TenantId
            );

            user.Name = name;
            user.Surname = surname;

            await _identityUserManager.CreateAsync(user,
                "1q2w3E*"
            );

            await _identityUserManager.AddToRoleAsync(user, "admin");
        }
    }
}