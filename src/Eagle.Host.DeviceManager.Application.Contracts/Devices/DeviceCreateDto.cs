using System;
using System.ComponentModel.DataAnnotations;

namespace Eagle.Host.DeviceManager.Devices
{
    public class DeviceCreateDto
    {

        [Required]
        public int Number { get; set; }

        [Required]
        [StringLength(DeviceConsts.NameMaxLength)]
        public string Name { get; set; }

    }
}