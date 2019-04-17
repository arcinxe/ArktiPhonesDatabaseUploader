using System.Collections.Generic;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
namespace ArktiPhonesDatabaseUploader
{
    interface IDeviceRepository
    {
        IQueryable<DeviceDetailDefault> GetDevices();
        DeviceDetailDefault AddDevice(DeviceDetailDefault device);
        void RemoveDevice(int id);
        void UpdateDevice(int id, DeviceDetailDefault device);
    }
}