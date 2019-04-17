using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class WlanBase {
        public bool? Available { get; set; }
 
    }

    // Used to work with SQL databases
    public class Wlan : WlanBase {
        public int WlanID { get; set; }

       public virtual ICollection<WlanStandard> Standards { get; set; }
        public virtual ICollection<WlanFeature> Features { get; set; }
        
        // public int CommunicationID { get; set; }
        public virtual Communication Communication { get; set; }
    }

    // Used locally in application
    public class WlanDefault : WlanBase {
        public virtual ICollection<WlanStandardDefault> Standards { get; set; }
        public virtual ICollection<WlanFeatureDefault> Features { get; set; }
    }
}
