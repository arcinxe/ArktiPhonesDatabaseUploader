using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class Camera
    {
        public string Location { get; set; }
        public double? Resolution { get; set; }
        public int? OpticalZoom { get; set; }
        public double? SensorSize { get; set; }  // 1/x.xx"
        public double? FocalLength { get; set; }  // x.xx mm
        public double? Aperture { get; set; }  // f/x.xx
        public ICollection<string> Features { get; set; }
    }
}
