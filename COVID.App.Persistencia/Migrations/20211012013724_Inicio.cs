using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID.App.Persistencia.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Clases_Claseid",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salones_Sedes_sedeid",
                table: "Salones");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropIndex(
                name: "IX_Personas_Claseid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Claseid",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "sedeid",
                table: "Salones",
                newName: "Sedeid");

            migrationBuilder.RenameIndex(
                name: "IX_Salones_sedeid",
                table: "Salones",
                newName: "IX_Salones_Sedeid");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CursoEstudiantes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estudianteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoEstudiantes", x => x.id);
                    table.ForeignKey(
                        name: "FK_CursoEstudiantes_Personas_Estudianteid",
                        column: x => x.Estudianteid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CursoProfesores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profesorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoProfesores", x => x.id);
                    table.ForeignKey(
                        name: "FK_CursoProfesores_Personas_Profesorid",
                        column: x => x.Profesorid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CursoSalones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salonid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoSalones", x => x.id);
                    table.ForeignKey(
                        name: "FK_CursoSalones_Salones_Salonid",
                        column: x => x.Salonid,
                        principalTable: "Salones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursoEstudiantes_Estudianteid",
                table: "CursoEstudiantes",
                column: "Estudianteid");

            migrationBuilder.CreateIndex(
                name: "IX_CursoProfesores_Profesorid",
                table: "CursoProfesores",
                column: "Profesorid");

            migrationBuilder.CreateIndex(
                name: "IX_CursoSalones_Salonid",
                table: "CursoSalones",
                column: "Salonid");

            migrationBuilder.AddForeignKey(
                name: "FK_Salones_Sedes_Sedeid",
                table: "Salones",
                column: "Sedeid",
                principalTable: "Sedes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salones_Sedes_Sedeid",
                table: "Salones");

            migrationBuilder.DropTable(
                name: "CursoEstudiantes");

            migrationBuilder.DropTable(
                name: "CursoProfesores");

            migrationBuilder.DropTable(
                name: "CursoSalones");

            migrationBuilder.RenameColumn(
                name: "Sedeid",
                table: "Salones",
                newName: "sedeid");

            migrationBuilder.RenameIndex(
                name: "IX_Salones_Sedeid",
                table: "Salones",
                newName: "IX_Salones_sedeid");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Claseid",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DuracionClase = table.Column<int>(type: "int", nullable: false),
                    cantidad_inscritos = table.Column<int>(type: "int", nullable: false),
                    hora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    profesorid = table.Column<int>(type: "int", nullable: true),
                    salonid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.id);
                    table.ForeignKey(
                        name: "FK_Clases_Personas_profesorid",
                        column: x => x.profesorid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clases_Salones_salonid",
                        column: x => x.salonid,
                        principalTable: "Salones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Claseid",
                table: "Personas",
                column: "Claseid");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_profesorid",
                table: "Clases",
                column: "profesorid");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_salonid",
                table: "Clases",
                column: "salonid");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Clases_Claseid",
                table: "Personas",
                column: "Claseid",
                principalTable: "Clases",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salones_Sedes_sedeid",
                table: "Salones",
                column: "sedeid",
                principalTable: "Sedes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
