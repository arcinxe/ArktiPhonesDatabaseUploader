namespace ArktiPhonesDatabaseUploader.Models {
    public class BasicBase {

        public int GsmArenaId { get; set; }
        public string Slug { get; set; }
        public string ImageUrl { get; set; }
        public string DeviceType { get; set; }
    }

    // Used to work with SQL databases
    public class Basic : BasicBase {
        public int BasicID { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class BasicDefault : BasicBase {

    }
}
