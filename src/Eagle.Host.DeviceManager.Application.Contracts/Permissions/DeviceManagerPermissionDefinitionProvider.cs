using Eagle.Host.DeviceManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Eagle.Host.DeviceManager.Permissions
{
    public class DeviceManagerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DeviceManagerPermissions.GroupName, L("Permission:DeviceManager"));

            var devicePermission = myGroup.AddPermission(DeviceManagerPermissions.Devices.Default, L("Permission:DeviceManager:Devices"));
            devicePermission.AddChild(DeviceManagerPermissions.Devices.Create, L("Permission:DeviceManager:Devices:Create"));
            devicePermission.AddChild(DeviceManagerPermissions.Devices.Edit, L("Permission:DeviceManager:Devices:Edit"));
            devicePermission.AddChild(DeviceManagerPermissions.Devices.Delete, L("Permission:DeviceManager:Devices:Delete"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DeviceManagerResource>(name);
        }
    }
}