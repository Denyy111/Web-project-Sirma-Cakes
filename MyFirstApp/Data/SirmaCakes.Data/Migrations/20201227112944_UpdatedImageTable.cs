using Microsoft.EntityFrameworkCore.Migrations;

namespace SirmaCakes.Data.Migrations
{
    public partial class UpdatedImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cakes_AspNetUsers_AddedByUserId",
                table: "Cakes");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_AddedByUserId1",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_AddedByUserId1",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "AddedByUserId1",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "AddbyUserId",
                table: "Cakes");

            migrationBuilder.RenameColumn(
                name: "RemoteimageUrl",
                table: "Images",
                newName: "RemoteImageUrl");

            migrationBuilder.RenameColumn(
                name: "AddedByUserId",
                table: "Cakes",
                newName: "AddedbyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cakes_AddedByUserId",
                table: "Cakes",
                newName: "IX_Cakes_AddedbyUserId");

            migrationBuilder.AlterColumn<string>(
                name: "AddedByUserId",
                table: "Images",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LongDescription",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CakeName",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateIndex(
                name: "IX_Images_AddedByUserId",
                table: "Images",
                column: "AddedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cakes_AspNetUsers_AddedbyUserId",
                table: "Cakes",
                column: "AddedbyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_AddedByUserId",
                table: "Images",
                column: "AddedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cakes_AspNetUsers_AddedbyUserId",
                table: "Cakes");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_AddedByUserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_AddedByUserId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "RemoteImageUrl",
                table: "Images",
                newName: "RemoteimageUrl");

            migrationBuilder.RenameColumn(
                name: "AddedbyUserId",
                table: "Cakes",
                newName: "AddedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cakes_AddedbyUserId",
                table: "Cakes",
                newName: "IX_Cakes_AddedByUserId");

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddedByUserId1",
                table: "Images",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Cakes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LongDescription",
                table: "Cakes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CakeName",
                table: "Cakes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddbyUserId",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_AddedByUserId1",
                table: "Images",
                column: "AddedByUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cakes_AspNetUsers_AddedByUserId",
                table: "Cakes",
                column: "AddedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_AddedByUserId1",
                table: "Images",
                column: "AddedByUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
