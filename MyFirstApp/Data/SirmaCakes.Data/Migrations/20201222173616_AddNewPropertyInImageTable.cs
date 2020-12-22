using Microsoft.EntityFrameworkCore.Migrations;

namespace SirmaCakes.Data.Migrations
{
    public partial class AddNewPropertyInImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RemoteimageUrl",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemoteimageUrl",
                table: "Images");
        }
    }
}
