using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcDentista1.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    Diente1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diente32 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAsistencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    ObraSocial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaTurno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diente");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Turno");
        }
    }
}
