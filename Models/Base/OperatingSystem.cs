namespace ArktiPhonesDatabaseUploader.Models {
    public class OperatingSystemBase {
        public string Name { get; set; }
        public string Version { get; set; }
        public string LatestVersion { get; set; }
        public string FlavorName { get; set; }
        public string FlavorVersion { get; set; }
    }

    // Used to work with SQL databases
    public class OperatingSystem : OperatingSystemBase {
        public int OperatingSystemID { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class OperatingSystemDefault : OperatingSystemBase {

    }
}
