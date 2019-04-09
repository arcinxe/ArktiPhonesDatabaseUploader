namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class Display
    {
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
}