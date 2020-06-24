using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Eagle.Host.DeviceManager.Pages
{
    public class IndexModel : DeviceManagerPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}