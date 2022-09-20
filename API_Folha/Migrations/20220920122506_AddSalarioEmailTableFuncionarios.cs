using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Folha.Migrations
{
    public partial class AddSalarioEmailTableFuncionarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Funcionarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Salario",
                table: "Funcionarios",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Funcionarios");
        }
    }
}
