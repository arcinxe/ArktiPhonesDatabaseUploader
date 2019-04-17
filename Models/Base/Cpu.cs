using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class CpuBase {
        public string Producer { get; set; }
        public string Name { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int? Cores { get; set; }
    }

    // Used to work with SQL databases
    public class Cpu : CpuBase {
        public int CpuID { get; set; }

        public virtual DeviceDetail DeviceDetail { get; set; }
    }

    // Used locally in application
    public class CpuDefault : CpuBase {

    }
}
