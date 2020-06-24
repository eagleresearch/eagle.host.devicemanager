using Volo.Abp.Reflection;

namespace Eagle.Host.DeviceManager.Permissions
{
    public class DeviceManagerPermissions
    {
        public const string GroupName = "DeviceManager";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(DeviceManagerPermissions));
        }

        public class Devices
        {
            public const string Default = GroupName + ".Devices";
            public const string Edit = Default + ".Edit";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}