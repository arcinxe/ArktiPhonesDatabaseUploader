using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
public class BasicConvert : IConverter<Basic, BasicDefault> {
    public BasicDefault Convert(Basic sourceObject) {
        var result = new BasicDefault() {
            DeviceType = sourceObject.DeviceType,
            GsmArenaId = sourceObject.GsmArenaId,
            ImageUrl = sourceObject.ImageUrl,
            Slug = sourceObject.Slug
        };

        return result;
    }

    public Basic Convert(BasicDefault sourceObject) {
        var result = new Basic() {
            DeviceType = sourceObject.DeviceType,
            GsmArenaId = sourceObject.GsmArenaId,
            ImageUrl = sourceObject.ImageUrl,
            Slug = sourceObject.Slug
        };

        return result;
    }
}