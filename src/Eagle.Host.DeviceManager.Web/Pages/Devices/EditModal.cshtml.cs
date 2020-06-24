using Eagle.Host.DeviceManager.Devices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Eagle.Host.DeviceManager.Web.Pages.Devices
{
    public class EditModalModel : DeviceManagerPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public DeviceUpdateDto Device { get; set; }

        private readonly IDeviceAppService _deviceAppService;

        public EditModalModel(IDeviceAppService deviceAppService)
        {
            _deviceAppService = deviceAppService;
        }

        public async Task OnGetAsync()
        {
            var device = await _deviceAppService.GetAsync(Id);
            try
            {
                Device = ObjectMapper.Map<DeviceDto, DeviceUpdateDto>(device);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _deviceAppService.UpdateAsync(Id, Device);
            return NoContent();
        }
    }
}