using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class SimCardBase {
        public string Type { get; set; }
    }

    // Used to work with SQL databases
    public class SimCard : SimCardBase {
        public int SimCardID { get; set; }

        public int CommunicationID { get; set; }
        public virtual Communication Communication { get; set; }
    }

    // Used locally in application
    public class SimCardDefault : SimCardBase {

    }
}
