using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class GpuBase {
        public string Name { get; set; }
        public string Model { get; set; }
    }

    // Used to work with SQL databases
    public class Gpu : GpuBase {
        public int GpuID { get; set; }

        public virtual DeviceDetail DeviceDetail { get; set; }
    }

    // Used locally in application
    public class GpuDefault : GpuBase {

    }
}
