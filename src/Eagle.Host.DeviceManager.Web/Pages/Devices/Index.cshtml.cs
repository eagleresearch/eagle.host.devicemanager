using Eagle.Host.DeviceManager.Devices;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Eagle.Host.DeviceManager.Web.Pages.Devices
{
    public class IndexModel : AbpPageModel
    {
        public int? NumberFilterMin { get; set; }

        public int? NumberFilterMax { get; set; }
        public string NameFilter { get; set; }

        private readonly IDeviceAppService _deviceAppService;

        public IndexModel(IDeviceAppService deviceAppService)
        {
            _deviceAppService = deviceAppService;
        }

        public async Task OnGetAsync()
        {

            await Task.CompletedTask;
        }
    }
}