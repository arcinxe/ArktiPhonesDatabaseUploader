using System.Collections.Generic;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
namespace ArktiPhonesDatabaseUploader {
    public class MongoDbRepository : IDeviceRepository {
        private readonly IMongoCollection<Models.DeviceDetailsMongo> _devices;

        public MongoDbRepository () {
            var client = new MongoClient ("mongodb://localhost:27017");
            var database = client.GetDatabase ("ArktiPhones");
            _devices = database.GetCollection<Models.DeviceDetailsMongo> ("Devices");
        }
        public Models.DeviceDetailDefault AddDevice (Models.DeviceDetailDefault device) {
            var newDevice = new Models.DeviceDetailsMongo (device);
            _devices.InsertOne (newDevice);
            return device;
        }

        public IQueryable<Models.DeviceDetailDefault> GetDevices () {
            return _devices.AsQueryable<Models.DeviceDetailsMongo> ();
        }

        public void RemoveDevice (int id) {
            _devices.DeleteOne (d => d.Basic.GsmArenaId == id);
        }

        public void UpdateDevice (int id, DeviceDetailDefault device) {
            var newDevice = new Models.DeviceDetailsMongo (device);
            _devices.ReplaceOneAsync (d => d.Basic.GsmArenaId == id, newDevice);
        }
    }
}
