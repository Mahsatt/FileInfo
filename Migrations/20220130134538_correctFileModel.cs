using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenge2.Migrations
{
    public partial class correctFileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Files");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Files",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArtikelCode",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveredIn",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountPrice",
                table: "Files",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Files",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Q1",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Files",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ArtikelCode",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "DeliveredIn",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Q1",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Files",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Id");
        }
    }
}
