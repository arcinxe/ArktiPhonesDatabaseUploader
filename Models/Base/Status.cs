namespace ArktiPhonesDatabaseUploader.Models {
    public class StatusBase {
        public string CurrentStatus { get; set; }
        public virtual Date AnnouncedDate { get; set; }
        public virtual Date ReleasedDate { get; set; }
        public string DatesOriginalText { get; set; }
    }

    // Used to work with SQL databases
    public class Status : StatusBase {
        public int StatusID { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class StatusDefault : StatusBase {

    }
}
