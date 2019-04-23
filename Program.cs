using System;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
using Microsoft.EntityFrameworkCore;

namespace ArktiPhonesDatabaseUploader {
    class Program {
        static void Main(string[] args) {
            var startTime = DateTime.Now;
            System.Console.WriteLine($"Started at {startTime}");
            var devices = new FileLoader().LoadDevices();
            // IDeviceRepository service = new MongoDbRepository ();
            // var count = 1;
            // foreach (var device in devices) {
            //     service.AddDevice (device);
            //     System.Console.WriteLine ($"Device {count++} out of {devices.Count}");
            // }
            var repo = new SqlDbRepository();
            var converter = new DeviceDetailConvert();
            var deviceToInsert = devices
                // .Take(100)
                .Select(d => converter.Convert(d));
            for (var i = 0; i < (deviceToInsert.Count() / 1000) + 1; i++) {
                repo.AddDevices(deviceToInsert.Skip(i * 1000).Take(1000));
            }
            // foreach (var device in devices) {
            //     repo.AddDevice(converter.Convert(device));
            //     System.Console.WriteLine ($"Device {count++} out of {devices.Count}");
            // }

            // var optionsBuilder = new DbContextOptionsBuilder<DeviceContext> ();
            // var db = new DeviceContext ();
            // var foo = new DeviceDetail ();
            // foo.Name = "test";
            // var bar = new DeviceDetailConvert().Convert(foo);
            // db.DeviceDetails.Add (foo);
            // db.SaveChanges ();
            // System.Console.WriteLine (db.Basics.Count ());
            // var device = service.GetDevices().Where(d => d.CameraInfo.Cameras.Count > 5).FirstOrDefault();
            // System.Console.WriteLine(device?.Basics.Name);
            // System.Console.WriteLine("Gud");
            // service.RemoveDevice(device.Basics.DeviceId);
            System.Console.WriteLine($"Done in: ~{(DateTime.Now - startTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
        }
    }
}
