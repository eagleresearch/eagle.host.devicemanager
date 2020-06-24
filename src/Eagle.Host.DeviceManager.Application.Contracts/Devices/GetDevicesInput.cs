using Volo.Abp.Application.Dtos;
using System;

namespace Eagle.Host.DeviceManager.Devices
{
    public class GetDevicesInput : PagedAndSortedResultRequestDto
    {
        public string FilterText { get; set; }

        public int? NumberMin { get; set; }
        public int? NumberMax { get; set; }
        public string Name { get; set; }

        public GetDevicesInput()
        {

        }
    }
}