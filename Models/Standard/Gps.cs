using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class Gps
    {
        public bool? Available { get; set; }
        public ICollection<string> Features { get; set; }
    }
}