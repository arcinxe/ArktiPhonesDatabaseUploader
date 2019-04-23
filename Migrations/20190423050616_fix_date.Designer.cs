﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArktiPhonesDatabaseUploader.Migrations
{
    [DbContext(typeof(DeviceContext))]
    [Migration("20190423050616_fix_date")]
    partial class fix_date
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Basic", b =>
                {
                    b.Property<int>("BasicID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeviceType");

                    b.Property<int>("GsmArenaId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Slug");

                    b.HasKey("BasicID");

                    b.ToTable("Basics");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Battery", b =>
                {
                    b.Property<int>("BatteryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Capacity");

                    b.Property<int?>("Endurance");

                    b.Property<string>("Technology");

                    b.HasKey("BatteryID");

                    b.ToTable("Batteries");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Build", b =>
                {
                    b.Property<int>("BuildID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DimensionsID");

                    b.Property<int?>("MaterialID");

                    b.Property<double?>("Weight");

                    b.HasKey("BuildID");

                    b.HasIndex("MaterialID")
                        .IsUnique()
                        .HasFilter("[MaterialID] IS NOT NULL");

                    b.ToTable("Builds");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Camera", b =>
                {
                    b.Property<int>("CameraID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Aperture");

                    b.Property<int>("CameraInfoID");

                    b.Property<double?>("FocalLength");

                    b.Property<string>("Location");

                    b.Property<int?>("OpticalZoom");

                    b.Property<double?>("Resolution");

                    b.Property<double?>("SensorSize");

                    b.HasKey("CameraID");

                    b.HasIndex("CameraInfoID");

                    b.ToTable("Camera");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.CameraFeature", b =>
                {
                    b.Property<int>("CameraFeatureID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CameraID");

                    b.Property<int?>("FrontCameraFeatureCameraInfoID");

                    b.Property<string>("Name");

                    b.Property<int?>("RearCameraFeatureCameraInfoID");

                    b.Property<int?>("VideoFeatureCameraInfoID");

                    b.HasKey("CameraFeatureID");

                    b.HasIndex("CameraID");

                    b.HasIndex("FrontCameraFeatureCameraInfoID");

                    b.HasIndex("RearCameraFeatureCameraInfoID");

                    b.HasIndex("VideoFeatureCameraInfoID");

                    b.ToTable("CameraFeature");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.CameraInfo", b =>
                {
                    b.Property<int>("CameraInfoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CameraOriginalText");

                    b.Property<int?>("FrontCameraLeds");

                    b.Property<double?>("PhotoResolution");

                    b.Property<int?>("RearCameraLeds");

                    b.Property<int?>("VideoResolution");

                    b.HasKey("CameraInfoID");

                    b.ToTable("CameraInfos");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Communication", b =>
                {
                    b.Property<int>("CommunicationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AudioJack");

                    b.Property<string>("Bluetooth");

                    b.Property<int?>("GpsID");

                    b.Property<bool>("Infrared");

                    b.Property<bool>("Nfc");

                    b.Property<int?>("UsbID");

                    b.Property<int?>("WlanID");

                    b.HasKey("CommunicationID");

                    b.HasIndex("GpsID")
                        .IsUnique()
                        .HasFilter("[GpsID] IS NOT NULL");

                    b.HasIndex("UsbID")
                        .IsUnique()
                        .HasFilter("[UsbID] IS NOT NULL");

                    b.HasIndex("WlanID")
                        .IsUnique()
                        .HasFilter("[WlanID] IS NOT NULL");

                    b.ToTable("Communications");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Cpu", b =>
                {
                    b.Property<int>("CpuID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Cores");

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.Property<string>("Producer");

                    b.Property<string>("Series");

                    b.HasKey("CpuID");

                    b.ToTable("Cpus");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Date", b =>
                {
                    b.Property<int>("DateID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnnouncedStatusID");

                    b.Property<int?>("Month");

                    b.Property<int?>("Quarter");

                    b.Property<int?>("ReleasedStatusID");

                    b.Property<int?>("Year");

                    b.HasKey("DateID");

                    b.HasIndex("AnnouncedStatusID")
                        .IsUnique()
                        .HasFilter("[AnnouncedStatusID] IS NOT NULL");

                    b.HasIndex("ReleasedStatusID")
                        .IsUnique()
                        .HasFilter("[ReleasedStatusID] IS NOT NULL");

                    b.ToTable("Date");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.DeviceColor", b =>
                {
                    b.Property<int>("DeviceColorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildID");

                    b.Property<string>("Name");

                    b.HasKey("DeviceColorID");

                    b.HasIndex("BuildID");

                    b.ToTable("DeviceColor");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.DeviceDetail", b =>
                {
                    b.Property<int>("DeviceDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasicID");

                    b.Property<int>("BatteryID");

                    b.Property<string>("Brand");

                    b.Property<int>("BuildID");

                    b.Property<int>("CameraInfoID");

                    b.Property<int>("CommunicationID");

                    b.Property<int>("CpuID");

                    b.Property<int>("DisplayID");

                    b.Property<int>("GpuID");

                    b.Property<int>("MemoryID");

                    b.Property<string>("Name");

                    b.Property<int>("OperatingSystemID");

                    b.Property<int>("PriceID");

                    b.Property<int>("StatusID");

                    b.HasKey("DeviceDetailID");

                    b.HasIndex("BasicID")
                        .IsUnique();

                    b.HasIndex("BatteryID")
                        .IsUnique();

                    b.HasIndex("BuildID")
                        .IsUnique();

                    b.HasIndex("CameraInfoID")
                        .IsUnique();

                    b.HasIndex("CommunicationID")
                        .IsUnique();

                    b.HasIndex("CpuID")
                        .IsUnique();

                    b.HasIndex("DisplayID")
                        .IsUnique();

                    b.HasIndex("GpuID")
                        .IsUnique();

                    b.HasIndex("MemoryID")
                        .IsUnique();

                    b.HasIndex("OperatingSystemID")
                        .IsUnique();

                    b.HasIndex("PriceID")
                        .IsUnique();

                    b.HasIndex("StatusID")
                        .IsUnique();

                    b.ToTable("DeviceDetails");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Dimension", b =>
                {
                    b.Property<int>("DimensionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildID");

                    b.Property<double?>("Height");

                    b.Property<double?>("Thickness");

                    b.Property<double?>("Volume");

                    b.Property<double?>("Width");

                    b.HasKey("DimensionID");

                    b.HasIndex("BuildID")
                        .IsUnique();

                    b.ToTable("Dimension");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Display", b =>
                {
                    b.Property<int>("DisplayID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Area");

                    b.Property<string>("ColorMode");

                    b.Property<int?>("Colors");

                    b.Property<double?>("Diagonal");

                    b.Property<int?>("EffectiveColors");

                    b.Property<double?>("HeightRatio");

                    b.Property<double?>("PixelDensity");

                    b.Property<int?>("ResolutionHeight");

                    b.Property<int?>("ResolutionLines");

                    b.Property<int?>("ResolutionWidth");

                    b.Property<double?>("ScreenToBodyRatio");

                    b.Property<string>("Touchscreen");

                    b.Property<string>("Type");

                    b.Property<double?>("WidthRatio");

                    b.HasKey("DisplayID");

                    b.ToTable("Displays");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Gps", b =>
                {
                    b.Property<int>("GpsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Available");

                    b.HasKey("GpsID");

                    b.ToTable("Gps");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.GpsFeature", b =>
                {
                    b.Property<int>("GpsFeatureID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GpsID");

                    b.Property<string>("Name");

                    b.HasKey("GpsFeatureID");

                    b.HasIndex("GpsID");

                    b.ToTable("GpsFeature");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Gpu", b =>
                {
                    b.Property<int>("GpuID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.HasKey("GpuID");

                    b.ToTable("Gpus");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Material", b =>
                {
                    b.Property<int>("MaterialID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Back");

                    b.Property<string>("Body");

                    b.Property<string>("Frame");

                    b.Property<string>("Front");

                    b.HasKey("MaterialID");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Memory", b =>
                {
                    b.Property<int>("MemoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CardMaxSize");

                    b.Property<string>("CardType");

                    b.Property<int?>("Internal");

                    b.Property<int?>("RandomAccess");

                    b.Property<int?>("ReadOnly");

                    b.HasKey("MemoryID");

                    b.ToTable("Memories");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.OperatingSystem", b =>
                {
                    b.Property<int>("OperatingSystemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FlavorName");

                    b.Property<string>("FlavorVersion");

                    b.Property<string>("LatestVersion");

                    b.Property<string>("Name");

                    b.Property<string>("Version");

                    b.HasKey("OperatingSystemID");

                    b.ToTable("OperatingSystems");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Price", b =>
                {
                    b.Property<int>("PriceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Currency");

                    b.Property<double?>("EstimatedInEuro");

                    b.Property<double?>("Value");

                    b.HasKey("PriceID");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Sensor", b =>
                {
                    b.Property<int>("SensorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommunicationID");

                    b.Property<string>("Name");

                    b.HasKey("SensorID");

                    b.HasIndex("CommunicationID");

                    b.ToTable("Sensor");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.SimCard", b =>
                {
                    b.Property<int>("SimCardID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommunicationID");

                    b.Property<string>("Type");

                    b.HasKey("SimCardID");

                    b.HasIndex("CommunicationID");

                    b.ToTable("SimCard");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrentStatus");

                    b.Property<string>("DatesOriginalText");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Usb", b =>
                {
                    b.Property<int>("UsbID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Connector");

                    b.Property<string>("Version");

                    b.HasKey("UsbID");

                    b.ToTable("Usb");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.UsbFeature", b =>
                {
                    b.Property<int>("UsbFeatureID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("UsbID");

                    b.HasKey("UsbFeatureID");

                    b.HasIndex("UsbID");

                    b.ToTable("UsbFeature");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.VideoMode", b =>
                {
                    b.Property<int>("VideoModeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CameraInfoID");

                    b.Property<string>("CameraSide");

                    b.Property<int?>("FrameRate");

                    b.Property<int?>("Height");

                    b.Property<int?>("Width");

                    b.HasKey("VideoModeID");

                    b.HasIndex("CameraInfoID");

                    b.ToTable("VideoMode");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Wlan", b =>
                {
                    b.Property<int>("WlanID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Available");

                    b.HasKey("WlanID");

                    b.ToTable("Wlan");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.WlanFeature", b =>
                {
                    b.Property<int>("WlanFeatureID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("WlanID");

                    b.HasKey("WlanFeatureID");

                    b.HasIndex("WlanID");

                    b.ToTable("WlanFeature");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.WlanStandard", b =>
                {
                    b.Property<int>("WlanStandardID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("WlanID");

                    b.HasKey("WlanStandardID");

                    b.HasIndex("WlanID");

                    b.ToTable("WlanStandard");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Build", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Material", "Material")
                        .WithOne("Build")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.Build", "MaterialID");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Camera", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.CameraInfo", "CameraInfo")
                        .WithMany("Cameras")
                        .HasForeignKey("CameraInfoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.CameraFeature", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Camera", "Camera")
                        .WithMany("Features")
                        .HasForeignKey("CameraID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.CameraInfo", "FrontCameraFeature")
                        .WithMany("FrontCameraFeatures")
                        .HasForeignKey("FrontCameraFeatureCameraInfoID");

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.CameraInfo", "RearCameraFeature")
                        .WithMany("RearCameraFeatures")
                        .HasForeignKey("RearCameraFeatureCameraInfoID");

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.CameraInfo", "VideoFeature")
                        .WithMany("VideoFeatures")
                        .HasForeignKey("VideoFeatureCameraInfoID");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Communication", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Gps", "Gps")
                        .WithOne("Communication")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.Communication", "GpsID");

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Usb", "Usb")
                        .WithOne("Communication")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.Communication", "UsbID");

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Wlan", "Wlan")
                        .WithOne("Communication")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.Communication", "WlanID");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Date", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Status", "AnnouncedStatus")
                        .WithOne("AnnouncedDate")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.Date", "AnnouncedStatusID");

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Status", "ReleasedStatus")
                        .WithOne("ReleasedDate")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.Date", "ReleasedStatusID");
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.DeviceColor", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Build", "Build")
                        .WithMany("Colors")
                        .HasForeignKey("BuildID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.DeviceDetail", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Basic", "Basic")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "BasicID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Battery", "Battery")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "BatteryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Build", "Build")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "BuildID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.CameraInfo", "CameraInfo")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "CameraInfoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Communication", "Communication")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "CommunicationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Cpu", "Cpu")
                        .WithOne("DeviceDetail")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "CpuID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Display", "Display")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "DisplayID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Gpu", "Gpu")
                        .WithOne("DeviceDetail")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "GpuID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Memory", "Memory")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "MemoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.OperatingSystem", "OperatingSystem")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "OperatingSystemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Price", "Price")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "PriceID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Status", "Status")
                        .WithOne("DeviceDetails")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.DeviceDetail", "StatusID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Dimension", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Build", "Build")
                        .WithOne("Dimension")
                        .HasForeignKey("ArktiPhonesDatabaseUploader.Models.Dimension", "BuildID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.GpsFeature", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Gps", "Gps")
                        .WithMany("Features")
                        .HasForeignKey("GpsID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.Sensor", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Communication", "Communication")
                        .WithMany("Sensors")
                        .HasForeignKey("CommunicationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.SimCard", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Communication", "Communication")
                        .WithMany("SimCards")
                        .HasForeignKey("CommunicationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.UsbFeature", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Usb", "Usb")
                        .WithMany("Features")
                        .HasForeignKey("UsbID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.VideoMode", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.CameraInfo", "CameraInfo")
                        .WithMany("VideoModes")
                        .HasForeignKey("CameraInfoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.WlanFeature", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Wlan", "Wlan")
                        .WithMany("Features")
                        .HasForeignKey("WlanID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ArktiPhonesDatabaseUploader.Models.WlanStandard", b =>
                {
                    b.HasOne("ArktiPhonesDatabaseUploader.Models.Wlan", "Wlan")
                        .WithMany("Standards")
                        .HasForeignKey("WlanID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
