using System.Collections.Generic;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models.Standard;

interface IDeviceRepository
{
    IQueryable<DeviceDetails> GetDevices();
     DeviceDetails AddDevice(DeviceDetails device);
    void RemoveDevice(int id);
    void UpdateDevice(int id, DeviceDetails device);
}
