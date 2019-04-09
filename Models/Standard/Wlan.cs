using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class Wlan
    {
        public bool? Available { get; set; }
        public ICollection<string> Standards { get; set; }
        public ICollection<string> Features { get; set; }
    }
}
