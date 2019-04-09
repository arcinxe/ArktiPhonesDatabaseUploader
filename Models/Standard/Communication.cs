using System.Collections.Generic;

namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class Communication
    {
        public ICollection<string> SimCards { get; set; }
        public Gps Gps { get; set; }
        public Usb Usb { get; set; }
        public Wlan Wlan { get; set; }
        public bool? AudioJack { get; set; }
        public string Bluetooth { get; set; }
        public bool Infrared { get; set; }
        public bool Nfc { get; set; }
        public ICollection<string> Sensors { get; set; }
    }
}