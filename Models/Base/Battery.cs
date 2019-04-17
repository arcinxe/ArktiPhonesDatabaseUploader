namespace ArktiPhonesDatabaseUploader.Models {
    public class BatteryBase {
        public int? Capacity { get; set; }
        public string Technology { get; set; }
        public int? Endurance { get; set; }
    }

    // Used to work with SQL databases
    public class Battery : BatteryBase {
        public int BatteryID { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class BatteryDefault : BatteryBase {

    }
}
