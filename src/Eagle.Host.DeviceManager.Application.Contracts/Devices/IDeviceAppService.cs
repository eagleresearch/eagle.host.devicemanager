using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Eagle.Host.DeviceManager.Devices
{
    public interface IDeviceAppService : IApplicationService
    {
        Task<PagedResultDto<DeviceDto>> GetListAsync(GetDevicesInput input);

        Task<DeviceDto> GetAsync(Guid id);

        Task DeleteAsync(Guid id);

        Task<DeviceDto> CreateAsync(DeviceCreateDto input);

        Task<DeviceDto> UpdateAsync(Guid id, DeviceUpdateDto input);
    }
}