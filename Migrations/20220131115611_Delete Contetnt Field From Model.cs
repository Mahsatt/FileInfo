using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenge2.Migrations
{
    public partial class DeleteContetntFieldFromModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Files");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "Files",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
