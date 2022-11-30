using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCasino2.Migrations
{
    /// <inheritdoc />
    public partial class Premios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RifaPremio",
                columns: table => new
                {
                    PremioId = table.Column<int>(type: "int", nullable: false),
                    RifaNombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RifaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RifaPremio", x => new { x.PremioId, x.RifaNombre });
                    table.ForeignKey(
                        name: "FK_RifaPremio_Premios_PremioId",
                        column: x => x.PremioId,
                        principalTable: "Premios",
                        principalColumn: "Nombre",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RifaPremio_Rifas_RifaId",
                        column: x => x.RifaId,
                        principalTable: "Rifas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RifaPremio_RifaId",
                table: "RifaPremio",
                column: "RifaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RifaPremio");
        }
    }
}
