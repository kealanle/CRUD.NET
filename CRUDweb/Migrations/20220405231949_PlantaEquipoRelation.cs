using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDweb.Migrations
{
    public partial class PlantaEquipoRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UltimaInspeccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Plantas_PlantaID",
                        column: x => x.PlantaID,
                        principalTable: "Plantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_PlantaID",
                table: "Equipos",
                column: "PlantaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipos");
        }
    }
}
