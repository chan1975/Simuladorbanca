using Microsoft.EntityFrameworkCore.Migrations;

namespace SimulacionBanca.Migrations
{
    public partial class CuentaIsUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_Numero",
                table: "Cuentas",
                column: "Numero",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cuentas_Numero",
                table: "Cuentas");
        }
    }
}
