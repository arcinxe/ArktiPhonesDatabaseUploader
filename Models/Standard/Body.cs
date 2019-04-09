using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class Body
    {
        public Dimensions Dimensions { get; set; }
        public Material Material { get; set; }
        public double? Weight { get; set; }
        public ICollection<string> Colors { get; set; }
    }
}