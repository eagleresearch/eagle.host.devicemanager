namespace Eagle.Host.DeviceManager
{
    public static class DeviceManagerDbProperties
    {
        public static string DbTablePrefix { get; set; } = "DeviceManager";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "DeviceManager";
    }
}
