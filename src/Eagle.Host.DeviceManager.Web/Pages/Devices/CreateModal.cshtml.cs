using Eagle.Host.DeviceManager.Devices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eagle.Host.DeviceManager.Web.Pages.Devices
{
    public class CreateModalModel : DeviceManagerPageModel
    {
        [BindProperty]
        public DeviceCreateDto Device { get; set; }

        private readonly IDeviceAppService _deviceAppService;

        public CreateModalModel(IDeviceAppService deviceAppService)
        {
            _deviceAppService = deviceAppService;
        }

        public async Task OnGetAsync()
        {
            Device = new DeviceCreateDto();

            await Task.CompletedTask;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _deviceAppService.CreateAsync(Device);
            return NoContent();
        }
    }
}