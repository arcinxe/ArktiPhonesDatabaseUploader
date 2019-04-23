using Microsoft.EntityFrameworkCore.Migrations;

namespace ArktiPhonesDatabaseUploader.Migrations
{
    public partial class fix_camera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature");

            migrationBuilder.AlterColumn<int>(
                name: "CameraID",
                table: "CameraFeature",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature",
                column: "CameraID",
                principalTable: "Camera",
                principalColumn: "CameraID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature");

            migrationBuilder.AlterColumn<int>(
                name: "CameraID",
                table: "CameraFeature",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature",
                column: "CameraID",
                principalTable: "Camera",
                principalColumn: "CameraID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
