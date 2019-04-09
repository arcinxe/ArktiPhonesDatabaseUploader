using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class CameraInfo
    {
        public double? PhotoResolution { get; set; }
        public int? VideoResolution { get; set; }
        public ICollection<VideoMode> VideoModes { get; set; }
        public ICollection<string> VideoFeatures { get; set; }
        public int? FrontCameraLeds { get; set; }
        public int? RearCameraLeds { get; set; }
        public ICollection<string> RearCameraFeatures { get; set; }
        public ICollection<string> FrontCameraFeatures { get; set; }
        public ICollection<Camera> Cameras { get; set; }
        public string CameraOriginalText { get; set; }
    }
}