using System;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
using Microsoft.EntityFrameworkCore;

namespace ArktiPhonesDatabaseUploader
{
    class Program
    {
        static void Main(string[] args)
        {
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
            var count = 0;
            var devicesToInsert = devices
                // .Take(100)
                .Select(d => converter.Convert(d));
            count = devicesToInsert.Count();
            for (var i = 0; i < (count / 100) + 1; i++)
            {
                System.Console.WriteLine($"{((double)i / count * 10000).ToString("#.##")}% - {i} out of {count / 100} done");
                repo.AddDevices(devicesToInsert.Skip(i * 100).Take(100));
            }
            // repo.AddDevice(deviceToInsert.FirstOrDefault());


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

            var db = new DeviceContextMsSqlServerFactory().CreateDbContext(new string[] { });
            var device = db.DeviceDetails.Where(d => d.CameraInfo.Cameras.Count > 5).FirstOrDefault();
            System.Console.WriteLine(device?.Name);
            System.Console.WriteLine("Gud");
            var id = device.Basic.GsmArenaId;
            // repo.RemoveDevice(device.Basic.GsmArenaId);
            System.Console.WriteLine($"Done in: ~{(DateTime.Now - startTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
        }
    }
}
