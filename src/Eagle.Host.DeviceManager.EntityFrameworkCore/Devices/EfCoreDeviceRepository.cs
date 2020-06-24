using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Eagle.Host.DeviceManager.EntityFrameworkCore;

namespace Eagle.Host.DeviceManager.Devices
{
    public class EfCoreDeviceRepository : EfCoreRepository<DeviceManagerDbContext, Device, Guid>, IDeviceRepository
    {
        public EfCoreDeviceRepository(IDbContextProvider<DeviceManagerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public async Task<List<Device>> GetListAsync(
            string filterText = null,
            int? numberMin = null,
            int? numberMax = null,
            string name = null,
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            CancellationToken cancellationToken = default)
        {
            var query = ApplyFilter(DbSet, filterText, numberMin, numberMax, name);
            query = query.OrderBy(string.IsNullOrWhiteSpace(sorting) ? DeviceConsts.DefaultSorting : sorting);
            return await query.PageBy(skipCount, maxResultCount).ToListAsync(cancellationToken);
        }

        public async Task<long> GetCountAsync(
            string filterText = null,
            int? numberMin = null,
            int? numberMax = null,
            string name = null,
            CancellationToken cancellationToken = default)
        {
            var query = ApplyFilter(DbSet, filterText, numberMin, numberMax, name);
            return await query.LongCountAsync(GetCancellationToken(cancellationToken));
        }

        protected virtual IQueryable<Device> ApplyFilter(
            IQueryable<Device> query,
            string filterText,
            int? numberMin = null,
            int? numberMax = null,
            string name = null)
        {
            return query
                    .WhereIf(!string.IsNullOrWhiteSpace(filterText), e => e.Name.Contains(filterText))
                    .WhereIf(numberMin.HasValue, e => e.Number >= numberMin.Value)
                    .WhereIf(numberMax.HasValue, e => e.Number <= numberMax.Value)
                    .WhereIf(!string.IsNullOrWhiteSpace(name), e => e.Name.Contains(name));
        }
    }
}