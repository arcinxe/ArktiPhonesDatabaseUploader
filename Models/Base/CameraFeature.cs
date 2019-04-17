using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class CameraFeatureBase {
        public string Name { get; set; }
    }

    // Used to work with SQL databases
    public class CameraFeature : CameraFeatureBase {
        public int CameraFeatureID { get; set; }

        // public int CameraInfoID { get; set; }
        // public virtual CameraInfo CameraInfo { get; set; }
        public virtual CameraInfo VideoFeature { get; set; }
        public virtual CameraInfo RearCameraFeature { get; set; }
        public virtual CameraInfo FrontCameraFeature { get; set; }
    }

    // Used locally in application
    public class CameraFeatureDefault : CameraFeatureBase {

    }

    public class CertainCameraFeature : CameraFeatureBase {
        public int CertainCameraFeatureID { get; set; }

        public int CameraID { get; set; }
        public virtual Camera Camera { get; set; }
    }
}
