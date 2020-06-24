using Eagle.Host.DeviceManager.Devices;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Eagle.Host.DeviceManager.EntityFrameworkCore
{
    [ConnectionStringName(DeviceManagerDbProperties.ConnectionStringName)]
    public class DeviceManagerDbContext : AbpDbContext<DeviceManagerDbContext>, IDeviceManagerDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DbSet<Device> Devices { get; set; }

        public DeviceManagerDbContext(DbContextOptions<DeviceManagerDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDeviceManager();
        }
    }
}