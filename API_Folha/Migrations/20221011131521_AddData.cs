using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Folha.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Folhas",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Mes",
                table: "Folhas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "Mes",
                table: "Folhas");
        }
    }
}
