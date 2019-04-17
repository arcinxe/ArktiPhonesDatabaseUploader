using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class UsbBase {
        public string Version { get; set; }
        public string Connector { get; set; }
    }

    // Used to work with SQL databases
    public class Usb : UsbBase {
        public int UsbID { get; set; }

        public virtual ICollection<UsbFeature> Features { get; set; }

        // public int CommunicationID { get; set; }
        public virtual Communication Communication { get; set; }
    }

    // Used locally in application
    public class UsbDefault : UsbBase {
        public ICollection<UsbFeatureDefault> Features { get; set; }

    }
}
