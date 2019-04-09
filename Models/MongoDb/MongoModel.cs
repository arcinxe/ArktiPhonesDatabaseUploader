using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ArktiPhonesDatabaseUploader.Models.Standard;



namespace ArktiPhonesDatabaseUploader.Models.MongoDB
{
    public class MongoModel : DeviceDetails
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public MongoModel()
        {
        }

        public MongoModel(DeviceDetails device)
        {
            Basics = device.Basics;
            Status = device.Status;
            Battery = device.Battery;
            Display = device.Display;
            Communication = device.Communication;
            Body = device.Body;
            CameraInfo = device.CameraInfo;
            Memory = device.Memory;
            Price = device.Price;
            OperatingSystem = device.OperatingSystem;
            Cpu = device.Cpu;
            Gpu = device.Gpu;
        }
    }
}