using Eagle.Host.DeviceManager.Devices;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Eagle.Host.DeviceManager.EntityFrameworkCore
{
    [ConnectionStringName(DeviceManagerDbProperties.ConnectionStringName)]
    public interface IDeviceManagerDbContext : IEfCoreDbContext
    {
        DbSet<Device> Devices { get; }
    }
}