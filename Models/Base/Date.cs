namespace ArktiPhonesDatabaseUploader.Models {
    public class DateBase {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Quarter { get; set; }
    }

    // Used to work with SQL databases
    public class Date : DateBase {
        public int DateID { get; set; }

        public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class DateDefault : DateBase {

    }
}
