namespace ArktiPhonesDatabaseUploader.Models {
    public class DisplayBase {
        public int? ResolutionWidth { get; set; }
        public int? ResolutionHeight { get; set; }
        public int? ResolutionLines { get; set; }
        public double? PixelDensity { get; set; }
        public double? WidthRatio { get; set; }
        public double? HeightRatio { get; set; }
        public double? Diagonal { get; set; }
        public double? Area { get; set; }
        public double? ScreenToBodyRatio { get; set; }
        public string Type { get; set; }
        public string ColorMode { get; set; }
        public int? Colors { get; set; }
        public int? EffectiveColors { get; set; }
        public string Touchscreen { get; set; }
    }

    // Used to work with SQL databases
    public class Display : DisplayBase {
        public int DisplayID { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class DisplayDefault : DisplayBase {

    }
}
