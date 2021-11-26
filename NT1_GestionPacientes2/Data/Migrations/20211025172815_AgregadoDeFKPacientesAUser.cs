using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1_GestionPacientes2.Data.Migrations
{
    public partial class AgregadoDeFKPacientesAUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PacienteId",
                table: "AspNetUsers",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Paciente_PacienteId",
                table: "AspNetUsers",
                column: "PacienteId",
                principalTable: "Paciente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Paciente_PacienteId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PacienteId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "AspNetUsers");
        }
    }
}
