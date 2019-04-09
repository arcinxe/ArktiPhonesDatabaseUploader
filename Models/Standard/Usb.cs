using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class Usb
    {
        public string Version { get; set; }
        public string Connector { get; set; }
        public ICollection<string> Features { get; set; }
    }
}
