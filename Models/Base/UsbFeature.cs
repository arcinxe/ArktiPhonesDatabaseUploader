using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class UsbFeatureBase {
        public string Name { get; set; }
    }

    // Used to work with SQL databases
    public class UsbFeature : UsbFeatureBase {
        public int UsbFeatureID { get; set; }

        public int UsbID { get; set; }
        public virtual Usb Usb { get; set; }
    }

    // Used locally in application
    public class UsbFeatureDefault : UsbFeatureBase {

    }
}
