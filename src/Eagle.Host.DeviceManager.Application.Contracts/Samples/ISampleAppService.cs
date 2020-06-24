using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Eagle.Host.DeviceManager.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
