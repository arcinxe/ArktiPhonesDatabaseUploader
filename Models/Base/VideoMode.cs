using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class VideoModeBase {
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? FrameRate { get; set; }
        public string CameraSide { get; set; }
    }

    // Used to work with SQL databases
    public class VideoMode : VideoModeBase {
        public int VideoModeID { get; set; }

        public int CameraInfoID { get; set; }
        public virtual CameraInfo CameraInfo { get; set; }
    }

    // Used locally in application
    public class VideoModeDefault : VideoModeBase {

    }
}
