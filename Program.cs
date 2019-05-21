using System;
using System.Collections.Generic;
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



            // using (var dbb = new TestContext())
            // {
            //     var basic = new Basic { GsmArenaNumber = 34, DeviceType = "phone", Slug = "shitty-phone", ImageUrl = "http://sugonde.se" };
            //     var dev = new DeviceDetail { Brand = "testing", Name = "shit", Basic = basic };
            //     dev.Basic.DeviceDetails = dev;
            //     dbb.DeviceDetails.Add(dev);
            //     dbb.SaveChanges();
            // }
            // foreach (var device in devices) {
            //     repo.AddDevice(converter.Convert(device));
            //     System.Console.WriteLine ($"Device {count++} out of {devices.Count}");
            // }
            // var optionsBuilder = new DbContextOptionsBuilder<DeviceContext> ();
            var db = new DeviceContext();
            // var phones = db.DeviceDetails
            // .Include(d => d.Basic)
            // .Include(d => d.Battery)
            // .Include(d => d.Build)
            // .Include(d => d.CameraInfo).ThenInclude(c => c.Cameras).ThenInclude(c => c.Features)
            // .Include(d => d.Communication).ThenInclude(c => c.Gps)
            // .Include(d => d.Communication).ThenInclude(c => c.Usb)
            // .Include(d => d.Communication).ThenInclude(c => c.Wlan)
            // .Include(d => d.Cpu)
            // .Include(d => d.Display)
            // .Include(d => d.Memory)
            // .Include(d => d.OperatingSystem)
            // .Include(d => d.Price)
            // .Include(d => d.Status).ToList();
            // var foo = new DeviceDetail ();
            // foo.Name = "test";
            // var bar = new DeviceDetailConvert().Convert(foo);
            // db.DeviceDetails.Add (foo);
            // db.SaveChanges ();
            System.Console.WriteLine(db.DeviceDetails.Count());
            var temp = db.DeviceDetails.FirstOrDefault();
            var device = db.DeviceDetails.Where(d => d.CameraInfo.Cameras.Count > 5).FirstOrDefault();
            var devicez = db.DeviceDetails.Take(10).ToList();
            var foo = devicez.ElementAt(4).CameraInfo.Cameras.FirstOrDefault().Resolution;
            System.Console.WriteLine(temp?.Basic.Slug);
            // System.Console.WriteLine("Gud");
            // service.RemoveDevice(device.Basics.DeviceId);


            // var db = new TestContext();
            // // var colors = new List<Color>() { new Color { Name = "blue" }, new Color { Name = "red" }, new Color { Name = "green" }, new Color { Name = "yellow" }, };
            // // var phone = new Phone { Name = "some name", Colors = colors, Foo = new Foo{ Bar = "tis ists"} };

            // // var basic = new Basic { GsmArenaNumber = 34, DeviceType = "phone", Slug = "shitty-phone", ImageUrl = "http://sugonde.se" };
            // // var dev = new DeviceDetail { Brand = "testing", Name = "shit", Basic = basic };
            // // db.Phones.Add(dev);
            // // db.SaveChanges();
            // var foo = db.DeviceDetails.FirstOrDefault();
            // System.Console.WriteLine(foo.Basic.Slug);
            // System.Console.WriteLine(foo.Basic.ImageUrl);

            System.Console.WriteLine($"Done in: ~{(DateTime.Now - startTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
        }
    }
}
