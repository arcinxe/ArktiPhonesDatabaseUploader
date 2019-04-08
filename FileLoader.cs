using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class FileLoader
{
    public List<DeviceDetails> Devices { get; set; }
    public List<DeviceDetails> LoadDevices()
    {
        var file = System.IO.File.ReadAllText(Path.Combine("Input", "AllDevicesDetails.json"));
        Devices = JsonConvert.DeserializeObject<List<DeviceDetails>>(file);
        return Devices;
    }
}