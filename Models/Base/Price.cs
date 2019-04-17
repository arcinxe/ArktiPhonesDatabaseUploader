namespace ArktiPhonesDatabaseUploader.Models {
    public class PriceBase {
        public double? Value { get; set; }
        public string Currency { get; set; }
        public double? EstimatedInEuro { get; set; }
    }

    // Used to work with SQL databases
    public class Price : PriceBase {
        public int PriceID { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class PriceDefault : PriceBase {

    }
}
