using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class DeviceColorBase {
        public string Name { get; set; }
    }

    // Used to work with SQL databases
    public class DeviceColor : DeviceColorBase {
        public int DeviceColorID { get; set; }

        public int BuildID { get; set; }
        public virtual Build Build { get; set; }
    }

    // Used locally in application
    public class DeviceColorDefault : DeviceColorBase {

    }
}
