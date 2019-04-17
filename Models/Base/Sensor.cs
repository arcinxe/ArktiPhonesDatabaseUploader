using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class SensorBase {
        public string Name { get; set; }
    }

    // Used to work with SQL databases
    public class Sensor : SensorBase {
        public int SensorID { get; set; }

        public int CommunicationID { get; set; }
        public virtual Communication Communication { get; set; }
    }

    // Used locally in application
    public class SensorDefault : SensorBase {

    }
}
