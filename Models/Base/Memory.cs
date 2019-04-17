namespace ArktiPhonesDatabaseUploader.Models {
    public class MemoryBase {
        public string CardType { get; set; }
        public int? CardMaxSize { get; set; }
        public int? Internal { get; set; }
        public int? ReadOnly { get; set; }
        public int? RandomAccess { get; set; }
    }

    // Used to work with SQL databases
    public class Memory : MemoryBase {
        public int MemoryID { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class MemoryDefault : MemoryBase {

    }
}
