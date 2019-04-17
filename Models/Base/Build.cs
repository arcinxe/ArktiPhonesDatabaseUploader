using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models {
    public class BuildBase {
        public double? Weight { get; set; }
    }

    // Used to work with SQL databases
    public class Build : BuildBase {
        public int BuildID { get; set; }

        public int? DimensionsID { get; set; }
        public int? MaterialID { get; set; }

        public virtual Dimension Dimension { get; set; }
        public virtual Material Material { get; set; }
        public virtual ICollection<DeviceColor> Colors { get; set; }

        // public int DeviceDetailsID { get; set; }
        public virtual DeviceDetail DeviceDetails { get; set; }

        public Build () {
            Dimension = new Dimension ();
            Material = new Material ();
        }
    }

    // Used locally in application
    public class BuildDefault : BuildBase {

        public DimensionDefault Dimension { get; set; }
        public MaterialDefault Material { get; set; }
        public ICollection<DeviceColorDefault> Colors { get; set; }
        public BuildDefault () {
            Dimension = new DimensionDefault ();
            Material = new MaterialDefault ();
        }
    }
}
