using System.Collections.Generic;
using System.Linq;

interface IDeviceRepository
{
    IQueryable<DeviceDetails> GetDevices();
     DeviceDetails AddDevice(DeviceDetails device);
    void RemoveDevice(int id);
    void UpdateDevice(int id, DeviceDetails device);
}
