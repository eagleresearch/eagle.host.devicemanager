using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Eagle.Host.DeviceManager.Devices
{
    public interface IDeviceRepository : IRepository<Device, Guid>
    {
        Task<List<Device>> GetListAsync(
            string filterText = null,
            int? numberMin = null,
            int? numberMax = null,
            string name = null,
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            CancellationToken cancellationToken = default
        );

        Task<long> GetCountAsync(
            string filterText = null,
            int? numberMin = null,
            int? numberMax = null,
            string name = null,
            CancellationToken cancellationToken = default);
    }
}