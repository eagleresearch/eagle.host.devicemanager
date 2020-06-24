using System;
using Volo.Abp.Application.Dtos;

namespace Eagle.Host.DeviceManager.Devices
{
    public class DeviceDto : FullAuditedEntityDto<Guid>
    {

        public int Number { get; set; }

        public string Name { get; set; }

    }
}