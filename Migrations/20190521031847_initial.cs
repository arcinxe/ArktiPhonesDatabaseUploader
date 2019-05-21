using Microsoft.EntityFrameworkCore.Migrations;

namespace ArktiPhonesDatabaseUploader.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceDetails",
                columns: table => new
                {
                    DeviceDetailID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDetails", x => x.DeviceDetailID);
                });

            migrationBuilder.CreateTable(
                name: "Gps",
                columns: table => new
                {
                    GpsID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Available = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gps", x => x.GpsID);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    MaterialID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Front = table.Column<string>(nullable: true),
                    Back = table.Column<string>(nullable: true),
                    Frame = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.MaterialID);
                });

            migrationBuilder.CreateTable(
                name: "Usb",
                columns: table => new
                {
                    UsbID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Version = table.Column<string>(nullable: true),
                    Connector = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usb", x => x.UsbID);
                });

            migrationBuilder.CreateTable(
                name: "Wlan",
                columns: table => new
                {
                    WlanID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Available = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wlan", x => x.WlanID);
                });

            migrationBuilder.CreateTable(
                name: "Basics",
                columns: table => new
                {
                    BasicID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GsmArenaNumber = table.Column<int>(nullable: false),
                    Slug = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basics", x => x.BasicID);
                    table.ForeignKey(
                        name: "FK_Basics_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Batteries",
                columns: table => new
                {
                    BatteryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Capacity = table.Column<int>(nullable: true),
                    Technology = table.Column<string>(nullable: true),
                    Endurance = table.Column<int>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batteries", x => x.BatteryID);
                    table.ForeignKey(
                        name: "FK_Batteries_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CameraInfos",
                columns: table => new
                {
                    CameraInfoID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhotoResolution = table.Column<double>(nullable: true),
                    VideoResolution = table.Column<int>(nullable: true),
                    FrontCameraLeds = table.Column<int>(nullable: true),
                    RearCameraLeds = table.Column<int>(nullable: true),
                    CameraOriginalText = table.Column<string>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraInfos", x => x.CameraInfoID);
                    table.ForeignKey(
                        name: "FK_CameraInfos_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    CpuID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Producer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Cores = table.Column<int>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.CpuID);
                    table.ForeignKey(
                        name: "FK_Cpus_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Displays",
                columns: table => new
                {
                    DisplayID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResolutionWidth = table.Column<int>(nullable: true),
                    ResolutionHeight = table.Column<int>(nullable: true),
                    ResolutionLines = table.Column<int>(nullable: true),
                    PixelDensity = table.Column<double>(nullable: true),
                    WidthRatio = table.Column<double>(nullable: true),
                    HeightRatio = table.Column<double>(nullable: true),
                    Diagonal = table.Column<double>(nullable: true),
                    Area = table.Column<double>(nullable: true),
                    ScreenToBodyRatio = table.Column<double>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ColorMode = table.Column<string>(nullable: true),
                    Colors = table.Column<int>(nullable: true),
                    EffectiveColors = table.Column<int>(nullable: true),
                    Touchscreen = table.Column<string>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displays", x => x.DisplayID);
                    table.ForeignKey(
                        name: "FK_Displays_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    GpuID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.GpuID);
                    table.ForeignKey(
                        name: "FK_Gpus_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    MemoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardType = table.Column<string>(nullable: true),
                    CardMaxSize = table.Column<int>(nullable: true),
                    Internal = table.Column<int>(nullable: true),
                    ReadOnly = table.Column<int>(nullable: true),
                    RandomAccess = table.Column<int>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.MemoryID);
                    table.ForeignKey(
                        name: "FK_Memories_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    OperatingSystemID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    LatestVersion = table.Column<string>(nullable: true),
                    FlavorName = table.Column<string>(nullable: true),
                    FlavorVersion = table.Column<string>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.OperatingSystemID);
                    table.ForeignKey(
                        name: "FK_OperatingSystems_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    PriceID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<double>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    EstimatedInEuro = table.Column<double>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.PriceID);
                    table.ForeignKey(
                        name: "FK_Prices_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CurrentStatus = table.Column<string>(nullable: true),
                    DatesOriginalText = table.Column<string>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusID);
                    table.ForeignKey(
                        name: "FK_Statuses_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GpsFeatures",
                columns: table => new
                {
                    GpsFeatureID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    GpsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GpsFeatures", x => x.GpsFeatureID);
                    table.ForeignKey(
                        name: "FK_GpsFeatures_Gps_GpsID",
                        column: x => x.GpsID,
                        principalTable: "Gps",
                        principalColumn: "GpsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    BuildID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DimensionsID = table.Column<int>(nullable: true),
                    MaterialID = table.Column<int>(nullable: true),
                    Weight = table.Column<double>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.BuildID);
                    table.ForeignKey(
                        name: "FK_Builds_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Builds_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsbFeature",
                columns: table => new
                {
                    UsbFeatureID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    UsbID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsbFeature", x => x.UsbFeatureID);
                    table.ForeignKey(
                        name: "FK_UsbFeature_Usb_UsbID",
                        column: x => x.UsbID,
                        principalTable: "Usb",
                        principalColumn: "UsbID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communications",
                columns: table => new
                {
                    CommunicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AudioJack = table.Column<bool>(nullable: true),
                    Bluetooth = table.Column<string>(nullable: true),
                    Infrared = table.Column<bool>(nullable: false),
                    Nfc = table.Column<bool>(nullable: false),
                    GpsID = table.Column<int>(nullable: true),
                    UsbID = table.Column<int>(nullable: true),
                    WlanID = table.Column<int>(nullable: true),
                    DeviceDetailID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communications", x => x.CommunicationID);
                    table.ForeignKey(
                        name: "FK_Communications_DeviceDetails_DeviceDetailID",
                        column: x => x.DeviceDetailID,
                        principalTable: "DeviceDetails",
                        principalColumn: "DeviceDetailID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Communications_Gps_GpsID",
                        column: x => x.GpsID,
                        principalTable: "Gps",
                        principalColumn: "GpsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Communications_Usb_UsbID",
                        column: x => x.UsbID,
                        principalTable: "Usb",
                        principalColumn: "UsbID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Communications_Wlan_WlanID",
                        column: x => x.WlanID,
                        principalTable: "Wlan",
                        principalColumn: "WlanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WlanFeatures",
                columns: table => new
                {
                    WlanFeatureID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    WlanID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WlanFeatures", x => x.WlanFeatureID);
                    table.ForeignKey(
                        name: "FK_WlanFeatures_Wlan_WlanID",
                        column: x => x.WlanID,
                        principalTable: "Wlan",
                        principalColumn: "WlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WlanStandards",
                columns: table => new
                {
                    WlanStandardID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    WlanID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WlanStandards", x => x.WlanStandardID);
                    table.ForeignKey(
                        name: "FK_WlanStandards_Wlan_WlanID",
                        column: x => x.WlanID,
                        principalTable: "Wlan",
                        principalColumn: "WlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    CameraID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CameraInfoID = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Resolution = table.Column<double>(nullable: true),
                    OpticalZoom = table.Column<int>(nullable: true),
                    SensorSize = table.Column<double>(nullable: true),
                    FocalLength = table.Column<double>(nullable: true),
                    Aperture = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.CameraID);
                    table.ForeignKey(
                        name: "FK_Cameras_CameraInfos_CameraInfoID",
                        column: x => x.CameraInfoID,
                        principalTable: "CameraInfos",
                        principalColumn: "CameraInfoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoModes",
                columns: table => new
                {
                    VideoModeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Width = table.Column<int>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    FrameRate = table.Column<int>(nullable: true),
                    CameraSide = table.Column<string>(nullable: true),
                    CameraInfoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoModes", x => x.VideoModeID);
                    table.ForeignKey(
                        name: "FK_VideoModes_CameraInfos_CameraInfoID",
                        column: x => x.CameraInfoID,
                        principalTable: "CameraInfos",
                        principalColumn: "CameraInfoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Date",
                columns: table => new
                {
                    DateID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Year = table.Column<int>(nullable: true),
                    Month = table.Column<int>(nullable: true),
                    Quarter = table.Column<int>(nullable: true),
                    AnnouncedStatusID = table.Column<int>(nullable: true),
                    ReleasedStatusID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.DateID);
                    table.ForeignKey(
                        name: "FK_Date_Statuses_AnnouncedStatusID",
                        column: x => x.AnnouncedStatusID,
                        principalTable: "Statuses",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Date_Statuses_ReleasedStatusID",
                        column: x => x.ReleasedStatusID,
                        principalTable: "Statuses",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeviceColors",
                columns: table => new
                {
                    DeviceColorID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    BuildID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceColors", x => x.DeviceColorID);
                    table.ForeignKey(
                        name: "FK_DeviceColors_Builds_BuildID",
                        column: x => x.BuildID,
                        principalTable: "Builds",
                        principalColumn: "BuildID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dimension",
                columns: table => new
                {
                    DimensionID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Width = table.Column<double>(nullable: true),
                    Height = table.Column<double>(nullable: true),
                    Thickness = table.Column<double>(nullable: true),
                    Volume = table.Column<double>(nullable: true),
                    BuildID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimension", x => x.DimensionID);
                    table.ForeignKey(
                        name: "FK_Dimension_Builds_BuildID",
                        column: x => x.BuildID,
                        principalTable: "Builds",
                        principalColumn: "BuildID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sensors",
                columns: table => new
                {
                    SensorID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    CommunicationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors", x => x.SensorID);
                    table.ForeignKey(
                        name: "FK_Sensors_Communications_CommunicationID",
                        column: x => x.CommunicationID,
                        principalTable: "Communications",
                        principalColumn: "CommunicationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SimCards",
                columns: table => new
                {
                    SimCardID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(nullable: true),
                    CommunicationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimCards", x => x.SimCardID);
                    table.ForeignKey(
                        name: "FK_SimCards_Communications_CommunicationID",
                        column: x => x.CommunicationID,
                        principalTable: "Communications",
                        principalColumn: "CommunicationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CameraFeatures",
                columns: table => new
                {
                    CameraFeatureID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    CameraID = table.Column<int>(nullable: true),
                    VideoFeatureID = table.Column<int>(nullable: true),
                    RearCameraFeatureID = table.Column<int>(nullable: true),
                    FrontCameraFeatureID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraFeatures", x => x.CameraFeatureID);
                    table.ForeignKey(
                        name: "FK_CameraFeatures_Cameras_CameraID",
                        column: x => x.CameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CameraFeatures_CameraInfos_FrontCameraFeatureID",
                        column: x => x.FrontCameraFeatureID,
                        principalTable: "CameraInfos",
                        principalColumn: "CameraInfoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CameraFeatures_CameraInfos_RearCameraFeatureID",
                        column: x => x.RearCameraFeatureID,
                        principalTable: "CameraInfos",
                        principalColumn: "CameraInfoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CameraFeatures_CameraInfos_VideoFeatureID",
                        column: x => x.VideoFeatureID,
                        principalTable: "CameraInfos",
                        principalColumn: "CameraInfoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basics_DeviceDetailID",
                table: "Basics",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_DeviceDetailID",
                table: "Batteries",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Builds_DeviceDetailID",
                table: "Builds",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Builds_MaterialID",
                table: "Builds",
                column: "MaterialID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CameraFeatures_CameraID",
                table: "CameraFeatures",
                column: "CameraID");

            migrationBuilder.CreateIndex(
                name: "IX_CameraFeatures_FrontCameraFeatureID",
                table: "CameraFeatures",
                column: "FrontCameraFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_CameraFeatures_RearCameraFeatureID",
                table: "CameraFeatures",
                column: "RearCameraFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_CameraFeatures_VideoFeatureID",
                table: "CameraFeatures",
                column: "VideoFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_CameraInfos_DeviceDetailID",
                table: "CameraInfos",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_CameraInfoID",
                table: "Cameras",
                column: "CameraInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Communications_DeviceDetailID",
                table: "Communications",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Communications_GpsID",
                table: "Communications",
                column: "GpsID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Communications_UsbID",
                table: "Communications",
                column: "UsbID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Communications_WlanID",
                table: "Communications",
                column: "WlanID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_DeviceDetailID",
                table: "Cpus",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Date_AnnouncedStatusID",
                table: "Date",
                column: "AnnouncedStatusID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Date_ReleasedStatusID",
                table: "Date",
                column: "ReleasedStatusID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceColors_BuildID",
                table: "DeviceColors",
                column: "BuildID");

            migrationBuilder.CreateIndex(
                name: "IX_Dimension_BuildID",
                table: "Dimension",
                column: "BuildID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Displays_DeviceDetailID",
                table: "Displays",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GpsFeatures_GpsID",
                table: "GpsFeatures",
                column: "GpsID");

            migrationBuilder.CreateIndex(
                name: "IX_Gpus_DeviceDetailID",
                table: "Gpus",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Memories_DeviceDetailID",
                table: "Memories",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OperatingSystems_DeviceDetailID",
                table: "OperatingSystems",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prices_DeviceDetailID",
                table: "Prices",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sensors_CommunicationID",
                table: "Sensors",
                column: "CommunicationID");

            migrationBuilder.CreateIndex(
                name: "IX_SimCards_CommunicationID",
                table: "SimCards",
                column: "CommunicationID");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_DeviceDetailID",
                table: "Statuses",
                column: "DeviceDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsbFeature_UsbID",
                table: "UsbFeature",
                column: "UsbID");

            migrationBuilder.CreateIndex(
                name: "IX_VideoModes_CameraInfoID",
                table: "VideoModes",
                column: "CameraInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_WlanFeatures_WlanID",
                table: "WlanFeatures",
                column: "WlanID");

            migrationBuilder.CreateIndex(
                name: "IX_WlanStandards_WlanID",
                table: "WlanStandards",
                column: "WlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basics");

            migrationBuilder.DropTable(
                name: "Batteries");

            migrationBuilder.DropTable(
                name: "CameraFeatures");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Date");

            migrationBuilder.DropTable(
                name: "DeviceColors");

            migrationBuilder.DropTable(
                name: "Dimension");

            migrationBuilder.DropTable(
                name: "Displays");

            migrationBuilder.DropTable(
                name: "GpsFeatures");

            migrationBuilder.DropTable(
                name: "Gpus");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Sensors");

            migrationBuilder.DropTable(
                name: "SimCards");

            migrationBuilder.DropTable(
                name: "UsbFeature");

            migrationBuilder.DropTable(
                name: "VideoModes");

            migrationBuilder.DropTable(
                name: "WlanFeatures");

            migrationBuilder.DropTable(
                name: "WlanStandards");

            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "Communications");

            migrationBuilder.DropTable(
                name: "CameraInfos");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Gps");

            migrationBuilder.DropTable(
                name: "Usb");

            migrationBuilder.DropTable(
                name: "Wlan");

            migrationBuilder.DropTable(
                name: "DeviceDetails");
        }
    }
}
