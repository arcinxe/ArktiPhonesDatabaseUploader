using System;
using System.Linq;

namespace ArktiPhonesDatabaseUploader
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceRepository service = new MongoDbRepository();
            // var devices = new FileLoader().LoadDevices();
            // var count = 1;
            // foreach (var device in devices)
            // {
            //     service.AddDevice(device);
            //     System.Console.WriteLine($"Device {count++} out of {devices.Count}");
            // }
            var device = service.GetDevices().Where(d => d.CameraInfo.Cameras.Count > 5).FirstOrDefault();
            System.Console.WriteLine(device?.Basics.Name);
            System.Console.WriteLine("Gud");
            service.RemoveDevice(device.Basics.DeviceId);
        }
    }
}
