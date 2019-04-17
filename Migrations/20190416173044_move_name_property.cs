using Microsoft.EntityFrameworkCore.Migrations;

namespace ArktiPhonesDatabaseUploader.Migrations
{
    public partial class move_name_property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Basics");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Basics");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "DeviceDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DeviceDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "DeviceDetails");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DeviceDetails");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Basics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Basics",
                nullable: true);
        }
    }
}
