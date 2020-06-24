using AutoMapper;

namespace Eagle.Host.DeviceManager.Devices
{
    public class DeviceApplicationAutoMapperProfile : Profile
    {
        public DeviceApplicationAutoMapperProfile()
        {

            CreateMap<DeviceCreateDto, Device>();
            CreateMap<Device, DeviceDto>();
            CreateMap<DeviceUpdateDto, Device>();
            //.ForMember(d => d.TenantId, opt => opt.Ignore())
            //.ForMember(d => d.IsDeleted, opt => opt.Ignore())
            //.ForMember(d => d.DeleterId, opt => opt.Ignore())
            //.ForMember(d => d.DeletionTime, opt => opt.Ignore())
            //.ForMember(d => d.LastModificationTime, opt => opt.Ignore())
            //.ForMember(d => d.LastModifierId, opt => opt.Ignore())
            //.ForMember(d => d.CreationTime, opt => opt.Ignore())
            //.ForMember(d => d.CreatorId, opt => opt.Ignore())
            //.ForMember(d => d.ExtraProperties, opt => opt.Ignore())
            //.ForMember(d => d.ConcurrencyStamp, opt => opt.Ignore())
            //.ForMember(d => d.Id, opt => opt.Ignore());
        }
    }
}
