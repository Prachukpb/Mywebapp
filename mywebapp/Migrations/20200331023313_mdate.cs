using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace mywebapp.Migrations
{
    public partial class mdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "messagedOn",
                table: "MywebMessage",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "messagedOn",
                table: "MywebMessage");
        }
    }
}