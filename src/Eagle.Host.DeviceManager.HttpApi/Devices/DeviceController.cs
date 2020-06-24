//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Threading.Tasks;
//using Volo.Abp;
//using Volo.Abp.Application.Dtos;

//namespace Eagle.Host.DeviceManager.Devices
//{
//    [RemoteService]
//    [Route("api/DeviceManager/devices")]
//    public class DeviceController : DeviceManagerController, IDeviceAppService
//    {
//        private readonly IDeviceAppService _deviceAppService;

//        public DeviceController(IDeviceAppService deviceAppService)
//        {
//            _deviceAppService = deviceAppService;
//        }

//        [HttpGet]
//        [Route("{id?}")]
//        public Task<DeviceDto> GetAsync(Guid id)
//        {
//            return _deviceAppService.GetAsync(id);
//        }

//        [HttpGet]
//        public Task<PagedResultDto<DeviceDto>> GetListAsync(GetDevicesInput input)
//        {
//            return _deviceAppService.GetListAsync(input);
//        }

//        [HttpPost]
//        [Authorize]
//        public Task<DeviceDto> CreateAsync(DeviceCreateDto input)
//        {
//            return _deviceAppService.CreateAsync(input);
//        }

//        [HttpPut]
//        [Authorize]
//        public Task<DeviceDto> UpdateAsync(Guid id, DeviceUpdateDto input)
//        {
//            return _deviceAppService.UpdateAsync(id, input);
//        }

//        [HttpDelete]
//        [Authorize]
//        public Task DeleteAsync(Guid id)
//        {
//            return _deviceAppService.DeleteAsync(id);
//        }

//        //[HttpGet]
//        //[Route("authorized")]
//        //[Authorize]
//        //public Task<DeviceDto> GetAuthorizedAsync(Guid id)
//        //{
//        //    return _deviceAppService.GetAsync(id);
//        //}




//    }
//}