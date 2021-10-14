using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID.App.Persistencia.Migrations
{
    public partial class pruebaCovid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoriaClinicas_Personas_personaid",
                table: "HistoriaClinicas");

            migrationBuilder.DropIndex(
                name: "IX_HistoriaClinicas_personaid",
                table: "HistoriaClinicas");

            migrationBuilder.DropColumn(
                name: "personaid",
                table: "HistoriaClinicas");

            migrationBuilder.AddColumn<int>(
                name: "historiaclinicaid",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_historiaclinicaid",
                table: "Personas",
                column: "historiaclinicaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_HistoriaClinicas_historiaclinicaid",
                table: "Personas",
                column: "historiaclinicaid",
                principalTable: "HistoriaClinicas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_HistoriaClinicas_historiaclinicaid",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_historiaclinicaid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "historiaclinicaid",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "personaid",
                table: "HistoriaClinicas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_personaid",
                table: "HistoriaClinicas",
                column: "personaid");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriaClinicas_Personas_personaid",
                table: "HistoriaClinicas",
                column: "personaid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
