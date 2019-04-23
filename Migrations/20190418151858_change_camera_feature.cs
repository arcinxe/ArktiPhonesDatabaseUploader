using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArktiPhonesDatabaseUploader.Migrations
{
    public partial class change_camera_feature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertainCameraFeature");

            migrationBuilder.AddColumn<int>(
                name: "CameraID",
                table: "CameraFeature",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CameraInfoID",
                table: "CameraFeature",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CameraFeature_CameraID",
                table: "CameraFeature",
                column: "CameraID");

            migrationBuilder.CreateIndex(
                name: "IX_CameraFeature_CameraInfoID",
                table: "CameraFeature",
                column: "CameraInfoID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CameraFeature_Camera_CameraID",
                table: "CameraFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_CameraFeature_CameraInfos_CameraInfoID",
                table: "CameraFeature");

            migrationBuilder.DropIndex(
                name: "IX_CameraFeature_CameraID",
                table: "CameraFeature");

            migrationBuilder.DropIndex(
                name: "IX_CameraFeature_CameraInfoID",
                table: "CameraFeature");

            migrationBuilder.DropColumn(
                name: "CameraID",
                table: "CameraFeature");

            migrationBuilder.DropColumn(
                name: "CameraInfoID",
                table: "CameraFeature");

            migrationBuilder.CreateTable(
                name: "CertainCameraFeature",
                columns: table => new
                {
                    CertainCameraFeatureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CameraID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertainCameraFeature", x => x.CertainCameraFeatureID);
                    table.ForeignKey(
                        name: "FK_CertainCameraFeature_Camera_CameraID",
                        column: x => x.CameraID,
                        principalTable: "Camera",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertainCameraFeature_CameraID",
                table: "CertainCameraFeature",
                column: "CameraID");
        }
    }
}
