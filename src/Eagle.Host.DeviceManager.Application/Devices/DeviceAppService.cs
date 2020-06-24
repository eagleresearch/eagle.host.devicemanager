using Eagle.Host.DeviceManager.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Eagle.Host.DeviceManager.Devices
{

    [Authorize(DeviceManagerPermissions.Devices.Default)]
    public class DeviceAppService : ApplicationService, IDeviceAppService
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeviceAppService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public virtual async Task<PagedResultDto<DeviceDto>> GetListAsync(GetDevicesInput input)
        {
            var totalCount = await _deviceRepository.GetCountAsync(input.FilterText, input.NumberMin, input.NumberMax, input.Name);
            var items = await _deviceRepository.GetListAsync(input.FilterText, input.NumberMin, input.NumberMax, input.Name, input.Sorting, input.MaxResultCount, input.SkipCount);

            return new PagedResultDto<DeviceDto>
            {
                TotalCount = totalCount,
                Items = ObjectMapper.Map<List<Device>, List<DeviceDto>>(items)
            };
        }

        public virtual async Task<DeviceDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<Device, DeviceDto>(await _deviceRepository.GetAsync(id));
        }

        [Authorize(DeviceManagerPermissions.Devices.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            await _deviceRepository.DeleteAsync(id);
        }

        [Authorize(DeviceManagerPermissions.Devices.Create)]
        public virtual async Task<DeviceDto> CreateAsync(DeviceCreateDto input)
        {
            var newDevice = ObjectMapper.Map<DeviceCreateDto, Device>(input);
            newDevice.TenantId = CurrentTenant.Id;
            var device = await _deviceRepository.InsertAsync(newDevice);
            await CurrentUnitOfWork.SaveChangesAsync();
            return ObjectMapper.Map<Device, DeviceDto>(device);
        }

        [Authorize(DeviceManagerPermissions.Devices.Edit)]
        public virtual async Task<DeviceDto> UpdateAsync(Guid id, DeviceUpdateDto input)
        {
            var device = await _deviceRepository.GetAsync(id);
            ObjectMapper.Map(input, device);
            var updatedDevice = await _deviceRepository.UpdateAsync(device);
            return ObjectMapper.Map<Device, DeviceDto>(updatedDevice);
        }
    }
}