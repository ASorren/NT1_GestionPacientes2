using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1_GestionPacientes2.Data.Migrations
{
    public partial class AgregadoRelacionAUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TurnoId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TurnoId",
                table: "AspNetUsers",
                column: "TurnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Turno_TurnoId",
                table: "AspNetUsers",
                column: "TurnoId",
                principalTable: "Turno",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Turno_TurnoId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TurnoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TurnoId",
                table: "AspNetUsers");
        }
    }
}
