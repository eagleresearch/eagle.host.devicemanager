//namespace Eagle.Host.DeviceManager.Samples
//{
//    [RemoteService]
//    [Route("api/DeviceManager/sample")]
//    public class SampleController : DeviceManagerController, ISampleAppService
//    {
//        private readonly ISampleAppService _sampleAppService;

//        public SampleController(ISampleAppService sampleAppService)
//        {
//            _sampleAppService = sampleAppService;
//        }

//        [HttpGet]
//        public async Task<SampleDto> GetAsync()
//        {
//            return await _sampleAppService.GetAsync();
//        }

//        [HttpGet]
//        [Route("authorized")]
//        [Authorize]
//        public async Task<SampleDto> GetAuthorizedAsync()
//        {
//            return await _sampleAppService.GetAsync();
//        }
//    }
//}
