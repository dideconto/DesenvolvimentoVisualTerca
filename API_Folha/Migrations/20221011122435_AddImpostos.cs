using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Folha.Migrations
{
    public partial class AddImpostos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ImpostoFgts",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoInss",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoRenda",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioBruto",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioLiquido",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImpostoFgts",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "ImpostoInss",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "ImpostoRenda",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "SalarioBruto",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "SalarioLiquido",
                table: "Folhas");
        }
    }
}
