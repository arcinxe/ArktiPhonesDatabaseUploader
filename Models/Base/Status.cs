using System.ComponentModel.DataAnnotations.Schema;

namespace ArktiPhonesDatabaseUploader.Models {
    public class StatusBase {
        public string CurrentStatus { get; set; }

        public string DatesOriginalText { get; set; }
    }

    // Used to work with SQL databases
    public class Status : StatusBase {
        public int StatusID { get; set; }
        // public int AnnouncedDateID { get; set; }
        // public int ReleasedDateID { get; set; }

        // [InverseProperty("AnnouncedStatus")]

        // [ForeignKey("AnnouncedDateID")]
        public virtual Date AnnouncedDate { get; set; }

        // [InverseProperty("ReleasedStatus")]
        // [ForeignKey("ReleasedDateID")]
        public virtual Date ReleasedDate { get; set; }
        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class StatusDefault : StatusBase {
        public virtual DateDefault AnnouncedDate { get; set; }
        public virtual DateDefault ReleasedDate { get; set; }
    }
}
