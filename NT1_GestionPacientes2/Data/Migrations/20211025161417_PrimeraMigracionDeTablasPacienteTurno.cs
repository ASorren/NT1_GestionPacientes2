using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1_GestionPacientes2.Data.Migrations
{
    public partial class PrimeraMigracionDeTablasPacienteTurno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    beneficio = table.Column<string>(nullable: false),
                    edad = table.Column<int>(nullable: false),
                    telefono = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: false),
                    horario = table.Column<DateTime>(nullable: false),
                    tipoConsulta = table.Column<string>(nullable: false),
                    obraSocial = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Turno");
        }
    }
}
