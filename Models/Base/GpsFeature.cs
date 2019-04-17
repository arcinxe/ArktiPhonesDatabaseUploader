using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class GpsFeatureBase {
        public string Name { get; set; }
    }

    // Used to work with SQL databases
    public class GpsFeature : GpsFeatureBase {
        public int GpsFeatureID { get; set; }

       public int GpsID { get; set; }
        public virtual Gps Gps { get; set; }
    }

    // Used locally in application
    public class GpsFeatureDefault : GpsFeatureBase {

    }
}
