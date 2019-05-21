// using System.Collections;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations.Schema;
// // using ArktiPhonesDatabaseUploader.Models;
// using Microsoft.EntityFrameworkCore;



// public class TestContext : DbContext
// {
//     // public DbSet<Phone> Phones { get; set; }
//     public DbSet<DeviceDetail> DeviceDetails { get; set; }
//     public DbSet<Basic> Basics { get; set; }
//     // public DbSet<Color> Colors { get; set; }



//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         optionsBuilder
//             .UseLazyLoadingProxies(true)
//             .UseSqlServer(@"server=localhost;database=Testing;User ID=sa;password=Qwertyui0;");
//         // .UseOracle(@"User Id=C##arktin;Password=Qwertyui0;Data Source=localhost:1521/orcl");
//         // .UseLazyLoadingProxies(true).UseSqlite("Data Source=ArktiPhones.db");
//     }


// }
// //   public class Phone
// //     {
// //         public int PhoneID { get; set; }
// //         public string Name { get; set; }
// //         public virtual Foo Foo { get; set; }
// //         public virtual ICollection<Color> Colors { get; set; }

// //     }
// //     public class Color
// //     {

// //         public int ColorID { get; set; }
// //         public string Name { get; set; }
// //         public int PhoneID { get; set; }
// //         public virtual Phone Phone { get; set; }

// //     }
// //     public class Foo
// //     {

// //         public int FooID { get; set; }
// //         public string Bar { get; set; }
// //         public int PhoneID { get; set; }
// //         public virtual Phone Phone { get; set; }

// //     }

// public class DeviceDetail
// {
//     public int DeviceDetailID { get; set; }

//     public string Brand { get; set; }
//     public string Name { get; set; }
//     public virtual Basic Basic { get; set; }
//     public virtual Status Status { get; set; }
//     public virtual Battery Battery { get; set; }
//     public virtual Display Display { get; set; }
//     public virtual Communication Communication { get; set; }
//     public virtual Build Build { get; set; }
//     public virtual CameraInfo CameraInfo { get; set; }
//     public virtual Memory Memory { get; set; }
//     public virtual Price Price { get; set; }
//     public virtual OperatingSystem OperatingSystem { get; set; }
//     public virtual Cpu Cpu { get; set; }
//     public virtual Gpu Gpu { get; set; }


// }

// public class Basic
// {
//     public int BasicID { get; set; }
//     public int GsmArenaNumber { get; set; }
//     public string Slug { get; set; }
//     public string ImageUrl { get; set; }
//     public string DeviceType { get; set; }
//     public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }
// }

// public class Battery
// {
//     public int BatteryID { get; set; }

//     public int? Capacity { get; set; }
//     public string Technology { get; set; }
//     public int? Endurance { get; set; }
//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }
// }

// public class Build
// {
//     public int BuildID { get; set; }

//     public int? DimensionsID { get; set; }
//     public int? MaterialID { get; set; }

//     public virtual Dimension Dimension { get; set; }
//     public virtual Material Material { get; set; }
//     public double? Weight { get; set; }
//     public virtual ICollection<DeviceColor> Colors { get; set; }

//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }

//     public Build()
//     {
//         Dimension = new Dimension();
//         Material = new Material();
//     }
// }

// public class Camera
// {
//     public int CameraID { get; set; }
//     public int CameraInfoID { get; set; }
//     public string Location { get; set; }
//     public double? Resolution { get; set; }
//     public int? OpticalZoom { get; set; }
//     public double? SensorSize { get; set; } // 1/x.xx"
//     public double? FocalLength { get; set; } // x.xx mm
//     public double? Aperture { get; set; } // f/x.xx
//     public virtual CameraInfo CameraInfo { get; set; }
//     public virtual ICollection<CameraFeature> Features { get; set; }
// }

// public class CameraFeature
// {
//     public int CameraFeatureID { get; set; }
//     public string Name { get; set; }

//     // public int CameraInfoID { get; set; }
//     // public virtual CameraInfo CameraInfo { get; set; }
//     public int? CameraID { get; set; }
//     public virtual Camera Camera { get; set; }
//     public int? VideoFeatureID { get; set; }
//     public virtual CameraInfo VideoFeature { get; set; }
//     public int? RearCameraFeatureID { get; set; }
//     public virtual CameraInfo RearCameraFeature { get; set; }
//     public int? FrontCameraFeatureID { get; set; }
//     public virtual CameraInfo FrontCameraFeature { get; set; }
// }

// public class CertainCameraFeature
// {
//     public int CertainCameraFeatureID { get; set; }
//     public string Name { get; set; }

//     public int CameraID { get; set; }
//     public virtual Camera Camera { get; set; }
// }

// public class CameraInfo
// {
//     public int CameraInfoID { get; set; }
//     public double? PhotoResolution { get; set; }
//     public int? VideoResolution { get; set; }
//     public int? FrontCameraLeds { get; set; }
//     public int? RearCameraLeds { get; set; }
//     public string CameraOriginalText { get; set; }
//     public virtual ICollection<VideoMode> VideoModes { get; set; }

//     [InverseProperty("VideoFeature")]
//     public virtual ICollection<CameraFeature> VideoFeatures { get; set; }

//     [InverseProperty("RearCameraFeature")]
//     public virtual ICollection<CameraFeature> RearCameraFeatures { get; set; }

//     [InverseProperty("FrontCameraFeature")]
//     public virtual ICollection<CameraFeature> FrontCameraFeatures { get; set; }

//     public virtual ICollection<Camera> Cameras { get; set; }

//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }
// }

// public class Communication
// {
//     public int CommunicationID { get; set; }
//     public bool? AudioJack { get; set; }
//     public string Bluetooth { get; set; }
//     public bool Infrared { get; set; }
//     public bool Nfc { get; set; }
//     public int? GpsID { get; set; }
//     public int? UsbID { get; set; }
//     public int? WlanID { get; set; }
//     public virtual Gps Gps { get; set; }
//     public virtual Usb Usb { get; set; }
//     public virtual Wlan Wlan { get; set; }
//     public virtual ICollection<SimCard> SimCards { get; set; }
//     public virtual ICollection<Sensor> Sensors { get; set; }

//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }

//     public Communication()
//     {
//         Gps = new Gps();
//         Usb = new Usb();
//         Wlan = new Wlan();
//     }
// }


// public class Cpu
// {
//     public int CpuID { get; set; }

//     public string Producer { get; set; }
//     public string Name { get; set; }
//     public string Series { get; set; }
//     public string Model { get; set; }
//     public int? Cores { get; set; }
//     public virtual DeviceDetail DeviceDetail { get; set; }
// }

// public class Date
// {
//     public int DateID { get; set; }

//     public int? Year { get; set; }
//     public int? Month { get; set; }
//     public int? Quarter { get; set; }
//     public int? AnnouncedStatusID { get; set; }
//     public int? ReleasedStatusID { get; set; }

//     [ForeignKey("AnnouncedStatusID")]
//     [InverseProperty("AnnouncedDate")]
//     public virtual Status AnnouncedStatus { get; set; }

//     [ForeignKey("ReleasedStatusID")]
//     [InverseProperty("ReleasedDate")]
//     public virtual Status ReleasedStatus { get; set; }
// }

// public class DeviceColor
// {
//     public int DeviceColorID { get; set; }
//     public string Name { get; set; }

//     public int BuildID { get; set; }
//     public virtual Build Build { get; set; }
// }

// public class Dimension
// {
//     public int DimensionID { get; set; }
//     public double? Width { get; set; }
//     public double? Height { get; set; }
//     public double? Thickness { get; set; }
//     public double? Volume { get; set; }
//     public int BuildID { get; set; }
//     public virtual Build Build { get; set; }
// }

// public class Display
// {
//     public int DisplayID { get; set; }
//     public int? ResolutionWidth { get; set; }
//     public int? ResolutionHeight { get; set; }
//     public int? ResolutionLines { get; set; }
//     public double? PixelDensity { get; set; }
//     public double? WidthRatio { get; set; }
//     public double? HeightRatio { get; set; }
//     public double? Diagonal { get; set; }
//     public double? Area { get; set; }
//     public double? ScreenToBodyRatio { get; set; }
//     public string Type { get; set; }
//     public string ColorMode { get; set; }
//     public int? Colors { get; set; }
//     public int? EffectiveColors { get; set; }
//     public string Touchscreen { get; set; }
//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }
// }

// public class Gps
// {
//     public int GpsID { get; set; }
//     public bool? Available { get; set; }
//     public virtual ICollection<GpsFeature> Features { get; set; }

//     // public int CommunicationID { get; set; }
//     public virtual Communication Communication { get; set; }
// }

// public class GpsFeature
// {
//     public int GpsFeatureID { get; set; }
//     public string Name { get; set; }

//     public int GpsID { get; set; }
//     public virtual Gps Gps { get; set; }
// }

// public class Gpu
// {
//     public int GpuID { get; set; }
//     public string Name { get; set; }
//     public string Model { get; set; }
//     public virtual DeviceDetail DeviceDetail { get; set; }
// }

// public class Material
// {
//     public int MaterialID { get; set; }
//     public string Front { get; set; }
//     public string Back { get; set; }
//     public string Frame { get; set; }
//     public string Body { get; set; }
//     // public int BuildID { get; set; }
//     public virtual Build Build { get; set; }
// }

// public class Memory
// {
//     public int MemoryID { get; set; }
//     public string CardType { get; set; }
//     public int? CardMaxSize { get; set; }
//     public int? Internal { get; set; }
//     public int? ReadOnly { get; set; }
//     public int? RandomAccess { get; set; }
//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }
// }


// public class OperatingSystem
// {
//     public int OperatingSystemID { get; set; }
//     public string Name { get; set; }
//     public string Version { get; set; }
//     public string LatestVersion { get; set; }
//     public string FlavorName { get; set; }
//     public string FlavorVersion { get; set; }
//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }
// }


// public class Price
// {
//     public int PriceID { get; set; }
//     public double? Value { get; set; }
//     public string Currency { get; set; }
//     public double? EstimatedInEuro { get; set; }
//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }
// }

// public class Sensor
// {
//     public int SensorID { get; set; }
//     public string Name { get; set; }

//     public int CommunicationID { get; set; }
//     public virtual Communication Communication { get; set; }
// }

// public class SimCard
// {
//     public int SimCardID { get; set; }
//     public string Type { get; set; }

//     public int CommunicationID { get; set; }
//     public virtual Communication Communication { get; set; }
// }

// public class Status
// {
//     public int StatusID { get; set; }
//     // public int AnnouncedDateID { get; set; }
//     // public int ReleasedDateID { get; set; }

//     public string CurrentStatus { get; set; }

//     public string DatesOriginalText { get; set; }
//     // [InverseProperty("AnnouncedStatus")]

//     // [ForeignKey("AnnouncedDateID")]
//     public virtual Date AnnouncedDate { get; set; }

//     // [InverseProperty("ReleasedStatus")]
//     // [ForeignKey("ReleasedDateID")]
//     public virtual Date ReleasedDate { get; set; }
//     // public int DeviceDetailsID { get; set; }
//     public virtual DeviceDetail DeviceDetails { get; set; }
// }


// public class Usb
// {
//     public int UsbID { get; set; }
//     public string Version { get; set; }
//     public string Connector { get; set; }
//     public virtual ICollection<UsbFeature> Features { get; set; }

//     // public int CommunicationID { get; set; }
//     public virtual Communication Communication { get; set; }
// }

// public class UsbFeature
// {
//     public int UsbFeatureID { get; set; }
//     public string Name { get; set; }
//     public int UsbID { get; set; }
//     public virtual Usb Usb { get; set; }
// }

// public class VideoMode
// {
//     public int VideoModeID { get; set; }
//     public int? Width { get; set; }
//     public int? Height { get; set; }
//     public int? FrameRate { get; set; }
//     public string CameraSide { get; set; }
//     public int CameraInfoID { get; set; }
//     public virtual CameraInfo CameraInfo { get; set; }
// }


// public class Wlan
// {
//     public int WlanID { get; set; }
//     public bool? Available { get; set; }
//     public virtual ICollection<WlanStandard> Standards { get; set; }
//     public virtual ICollection<WlanFeature> Features { get; set; }

//     // public int CommunicationID { get; set; }
//     public virtual Communication Communication { get; set; }
// }

// public class WlanFeature
// {
//     public int WlanFeatureID { get; set; }
//     public string Name { get; set; }

//     public int WlanID { get; set; }
//     public virtual Wlan Wlan { get; set; }

// }

// public class WlanStandard
// {
//     public int WlanStandardID { get; set; }
//     public string Name { get; set; }

//     public int WlanID { get; set; }
//     public virtual Wlan Wlan { get; set; }
// }