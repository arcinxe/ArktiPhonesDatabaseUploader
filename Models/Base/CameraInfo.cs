using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArktiPhonesDatabaseUploader.Models {
    public class CameraInfoBase {
        public double? PhotoResolution { get; set; }
        public int? VideoResolution { get; set; }
        public int? FrontCameraLeds { get; set; }
        public int? RearCameraLeds { get; set; }
        public string CameraOriginalText { get; set; }
    }

    // Used to work with SQL databases
    public class CameraInfo : CameraInfoBase {
        public int CameraInfoID { get; set; }

        public virtual ICollection<VideoMode> VideoModes { get; set; }

        [InverseProperty("VideoFeature")]
        public virtual ICollection<CameraFeature> VideoFeatures { get; set; }

        [InverseProperty("RearCameraFeature")]
        public virtual ICollection<CameraFeature> RearCameraFeatures { get; set; }

        [InverseProperty("FrontCameraFeature")]
        public virtual ICollection<CameraFeature> FrontCameraFeatures { get; set; }
        
        public virtual ICollection<Camera> Cameras { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }
    }

    // Used locally in application
    public class CameraInfoDefault : CameraInfoBase {
        public ICollection<VideoModeDefault> VideoModes { get; set; }
        public ICollection<CameraFeatureDefault> VideoFeatures { get; set; }
        public ICollection<CameraFeatureDefault> RearCameraFeatures { get; set; }
        public ICollection<CameraFeatureDefault> FrontCameraFeatures { get; set; }
        public ICollection<CameraDefault> Cameras { get; set; }

    }
}
