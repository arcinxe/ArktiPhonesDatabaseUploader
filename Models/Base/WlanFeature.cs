using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class WlanFeatureBase {
        public string Name { get; set; }
    }

    // Used to work with SQL databases
    public class WlanFeature : WlanFeatureBase {
        public int WlanFeatureID { get; set; }

                  public int WlanID { get; set; }
        public virtual Wlan Wlan { get; set; }
        
    }

    // Used locally in application
    public class WlanFeatureDefault : WlanFeatureBase {

    }
}
