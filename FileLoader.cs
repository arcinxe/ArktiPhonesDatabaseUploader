using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ArktiPhonesDatabaseUploader.Models;

public class FileLoader
{
    public List<DeviceDetailDefault> Devices { get; set; }
    public List<DeviceDetailDefault> LoadDevices()
    {
        var file = System.IO.File.ReadAllText(Path.Combine("Input", "AllDevicesDetails.json"));
        Devices = JsonConvert.DeserializeObject<List<DeviceDetailDefault>>(file);
        return Devices;
    }
}