using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ArktiPhonesDatabaseUploader.Models.Standard
{
    public class DeviceDetails
    {
        public Basics Basics { get; set; }
        public Status Status { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public Communication Communication { get; set; }
        public Body Body { get; set; }
        public CameraInfo CameraInfo { get; set; }
        public Memory Memory { get; set; }
        public Price Price { get; set; }
        public OperatingSystem OperatingSystem { get; set; }
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }

        public DeviceDetails()
        {
            Basics = new Basics();
            Status = new Status();
            Battery = new Battery();
            Display = new Display();
            Communication = new Communication();
            Communication.Usb = new Usb();
            Communication.Wlan = new Wlan();
            Communication.Gps = new Gps();
            Body = new Body();
            Body.Dimensions = new Dimensions();
            Body.Material = new Material();
            CameraInfo = new CameraInfo();
            Memory = new Memory();
            Price = new Price();
            OperatingSystem = new OperatingSystem();
            Cpu = new Cpu();
            Gpu = new Gpu();
        }
    }
}