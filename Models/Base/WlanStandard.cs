using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class WlanStandardBase {
        public string Name { get; set; }
    }

    // Used to work with SQL databases
    public class WlanStandard : WlanStandardBase {
        public int WlanStandardID { get; set; }

        public int WlanID { get; set; }
        public virtual Wlan Wlan { get; set; }
    }

    // Used locally in application
    public class WlanStandardDefault : WlanStandardBase {

    }
}
