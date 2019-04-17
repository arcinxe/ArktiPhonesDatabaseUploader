namespace ArktiPhonesDatabaseUploader.Models {
    public class DimensionBase {
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Thickness { get; set; }
        public double? Volume { get; set; }
    }

    // Used to work with SQL databases
    public class Dimension : DimensionBase {
        public int DimensionID { get; set; }

        public int BuildID { get; set; }
        public virtual Build Build { get; set; }
    }

    // Used locally in application
    public class DimensionDefault : DimensionBase {

    }
}
