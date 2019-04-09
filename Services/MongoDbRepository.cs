using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Microsoft.Extensions.Configuration;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models.MongoDB;
using ArktiPhonesDatabaseUploader.Models.Standard;

public class MongoDbRepository : IDeviceRepository
{
    private readonly IMongoCollection<MongoModel> _devices;

    public MongoDbRepository()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("ArktiPhones");
        _devices = database.GetCollection<MongoModel>("Devices");
    }
    public DeviceDetails AddDevice(DeviceDetails device)
    {
        var newDevice = new MongoModel(device);
        _devices.InsertOne(newDevice);
        return device;
    }

    public IQueryable<DeviceDetails> GetDevices()
    {
        return _devices.AsQueryable<MongoModel>();
    }

    public void RemoveDevice(int id)
    {
        _devices.DeleteOne(d => d.Basics.DeviceId == id);
    }

    public void UpdateDevice(int id, DeviceDetails device)
    {
        var newDevice = new MongoModel(device);
        _devices.ReplaceOneAsync(d => d.Basics.DeviceId == id, newDevice);
    }
}