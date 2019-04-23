using Microsoft.EntityFrameworkCore.Migrations;

namespace ArktiPhonesDatabaseUploader.Migrations
{
    public partial class fix_date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_CameraFeature_CameraInfos_CameraInfoID",
                table: "CameraFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_Date_DeviceDetails_DeviceDetailsID",
                table: "Date");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceDetails_Statuss_StatusID",
                table: "DeviceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuss_Date_AnnouncedDateDateID",
                table: "Statuss");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuss_Date_ReleasedDateDateID",
                table: "Statuss");

            migrationBuilder.DropIndex(
                name: "IX_Date_DeviceDetailsID",
                table: "Date");

            migrationBuilder.DropIndex(
                name: "IX_CameraFeature_CameraInfoID",
                table: "CameraFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuss",
                table: "Statuss");

            migrationBuilder.DropIndex(
                name: "IX_Statuss_AnnouncedDateDateID",
                table: "Statuss");

            migrationBuilder.DropIndex(
                name: "IX_Statuss_ReleasedDateDateID",
                table: "Statuss");

            migrationBuilder.DropColumn(
                name: "DeviceDetailsID",
                table: "Date");

            migrationBuilder.DropColumn(
                name: "CameraInfoID",
                table: "CameraFeature");

            migrationBuilder.DropColumn(
                name: "AnnouncedDateDateID",
                table: "Statuss");

            migrationBuilder.DropColumn(
                name: "ReleasedDateDateID",
                table: "Statuss");

            migrationBuilder.RenameTable(
                name: "Statuss",
                newName: "Status");

            migrationBuilder.AddColumn<int>(
                name: "AnnouncedStatusID",
                table: "Date",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReleasedStatusID",
                table: "Date",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CameraID",
                table: "CameraFeature",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Date_AnnouncedStatusID",
                table: "Date",
                column: "AnnouncedStatusID",
                unique: true,
                filter: "[AnnouncedStatusID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Date_ReleasedStatusID",
                table: "Date",
                column: "ReleasedStatusID",
                unique: true,
                filter: "[ReleasedStatusID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature",
                column: "CameraID",
                principalTable: "Camera",
                principalColumn: "CameraID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Date_Status_AnnouncedStatusID",
                table: "Date",
                column: "AnnouncedStatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Date_Status_ReleasedStatusID",
                table: "Date",
                column: "ReleasedStatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceDetails_Status_StatusID",
                table: "DeviceDetails",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_Date_Status_AnnouncedStatusID",
                table: "Date");

            migrationBuilder.DropForeignKey(
                name: "FK_Date_Status_ReleasedStatusID",
                table: "Date");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceDetails_Status_StatusID",
                table: "DeviceDetails");

            migrationBuilder.DropIndex(
                name: "IX_Date_AnnouncedStatusID",
                table: "Date");

            migrationBuilder.DropIndex(
                name: "IX_Date_ReleasedStatusID",
                table: "Date");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "AnnouncedStatusID",
                table: "Date");

            migrationBuilder.DropColumn(
                name: "ReleasedStatusID",
                table: "Date");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuss");

            migrationBuilder.AddColumn<int>(
                name: "DeviceDetailsID",
                table: "Date",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CameraID",
                table: "CameraFeature",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CameraInfoID",
                table: "CameraFeature",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnnouncedDateDateID",
                table: "Statuss",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReleasedDateDateID",
                table: "Statuss",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuss",
                table: "Statuss",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Date_DeviceDetailsID",
                table: "Date",
                column: "DeviceDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_CameraFeature_CameraInfoID",
                table: "CameraFeature",
                column: "CameraInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Statuss_AnnouncedDateDateID",
                table: "Statuss",
                column: "AnnouncedDateDateID");

            migrationBuilder.CreateIndex(
                name: "IX_Statuss_ReleasedDateDateID",
                table: "Statuss",
                column: "ReleasedDateDateID");

            migrationBuilder.AddForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature",
                column: "CameraID",
                principalTable: "Camera",
                principalColumn: "CameraID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CameraFeature_CameraInfos_CameraInfoID",
                table: "CameraFeature",
                column: "CameraInfoID",
                principalTable: "CameraInfos",
                principalColumn: "CameraInfoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Date_DeviceDetails_DeviceDetailsID",
                table: "Date",
                column: "DeviceDetailsID",
                principalTable: "DeviceDetails",
                principalColumn: "DeviceDetailID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceDetails_Statuss_StatusID",
                table: "DeviceDetails",
                column: "StatusID",
                principalTable: "Statuss",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuss_Date_AnnouncedDateDateID",
                table: "Statuss",
                column: "AnnouncedDateDateID",
                principalTable: "Date",
                principalColumn: "DateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuss_Date_ReleasedDateDateID",
                table: "Statuss",
                column: "ReleasedDateDateID",
                principalTable: "Date",
                principalColumn: "DateID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
