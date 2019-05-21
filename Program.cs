using System;
using System.Collections.Generic;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
using Microsoft.EntityFrameworkCore;

namespace ArktiPhonesDatabaseUploader {
    class Program {
        static void Main (string[] args) {
            var startTime = DateTime.Now;
            System.Console.WriteLine ($"Started at {startTime}");
            var devices = new FileLoader ().LoadDevices ();
            // IDeviceRepository service = new MongoDbRepository ();
            var count = 1;
            // foreach (var device in devices) {
            //     service.AddDevice (device);
            //     System.Console.WriteLine ($"Device {count++} out of {devices.Count}");
            // }

            // var repo = new SqlDbRepository();
            // var converter = new DeviceDetailConvert();
            // var deviceToInsert = devices
            //     // .Take(100)
            //     .Select(d => converter.Convert(d));
            // System.Console.WriteLine("HI!");
            // count = deviceToInsert.Count();
            // for (var i = 0; i < (count / 100) + 1; i++)
            // {
            //     var subStartTime = DateTime.Now;
            //     repo.AddDevices(deviceToInsert.Skip(i * 100).Take(100));
            //     System.Console.Write($"{((double)i / count * 10000).ToString("00.00")}% - {i} out of {count / 100} done");
            //     System.Console.WriteLine($" {(DateTime.Now - subStartTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
            // }

        
            // foreach (var device in devices) {
            //     repo.AddDevice(converter.Convert(device));
            //     System.Console.WriteLine ($"Device {count++} out of {devices.Count}");
            // }
            // var optionsBuilder = new DbContextOptionsBuilder<DeviceContext> ();
            var db = new DeviceContext ();
           
            System.Console.WriteLine (db.DeviceDetails.Count ());
            var temp = db.DeviceDetails.FirstOrDefault ();
            var device = db.DeviceDetails.Where (d => d.CameraInfo.Cameras.Count > 5).FirstOrDefault ();
            var devicez = db.DeviceDetails.Take (10).ToList ();
            var foo = devicez.ElementAt (4).CameraInfo.Cameras.FirstOrDefault ().Resolution;
            System.Console.WriteLine (temp?.Basic.Slug);
            // System.Console.WriteLine("Gud");
            // service.RemoveDevice(device.Basics.DeviceId);


            System.Console.WriteLine ($"Done in: ~{(DateTime.Now - startTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
        }
    }
}