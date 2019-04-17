using System;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
using Microsoft.EntityFrameworkCore;

namespace ArktiPhonesDatabaseUploader {
    class Program {
        static void Main (string[] args) {
            var devices = new FileLoader ().LoadDevices ();
            IDeviceRepository service = new MongoDbRepository ();
            var count = 1;
            foreach (var device in devices) {
                service.AddDevice (device);
                System.Console.WriteLine ($"Device {count++} out of {devices.Count}");
            }

            var optionsBuilder = new DbContextOptionsBuilder<DeviceContext> ();
            var db = new DeviceContext ();
            var foo = new DeviceDetail ();
            foo.Name = "test";
            db.DeviceDetails.Add (foo);
            db.SaveChanges ();
            System.Console.WriteLine (db.Basics.Count ());
            // var device = service.GetDevices().Where(d => d.CameraInfo.Cameras.Count > 5).FirstOrDefault();
            // System.Console.WriteLine(device?.Basics.Name);
            // System.Console.WriteLine("Gud");
            // service.RemoveDevice(device.Basics.DeviceId);
        }
    }
}
