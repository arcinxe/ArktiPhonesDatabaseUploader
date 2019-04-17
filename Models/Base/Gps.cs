using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class GpsBase {
        public bool? Available { get; set; }
    }

    // Used to work with SQL databases
    public class Gps : GpsBase {
        public int GpsID { get; set; }

        public virtual ICollection<GpsFeature> Features { get; set; }

        // public int CommunicationID { get; set; }
        public virtual Communication Communication { get; set; }
    }

    // Used locally in application and for noSQL databases
    public class GpsDefault : GpsBase {
        public ICollection<GpsFeatureDefault> Features { get; set; }
    }
}
