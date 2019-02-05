using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class SeedSplitComplementaryPalettes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monochromatic",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monochromatic", x => new { x.ColorOneID, x.ColorTwoID });
                    table.ForeignKey(
                        name: "FK_Monochromatic_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SplitComplimentaryPalettes",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ColorThreeID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SplitComplimentaryPalettes", x => new { x.ColorOneID, x.ColorTwoID, x.ColorThreeID });
                    table.ForeignKey(
                        name: "FK_SplitComplimentaryPalettes_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tetradic",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ColorThreeID = table.Column<int>(nullable: false),
                    ColorFourID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tetradic", x => new { x.ColorOneID, x.ColorTwoID, x.ColorThreeID, x.ColorFourID });
                    table.ForeignKey(
                        name: "FK_Tetradic_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Triadic",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ColorThreeID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Triadic", x => new { x.ColorOneID, x.ColorTwoID, x.ColorThreeID });
                    table.ForeignKey(
                        name: "FK_Triadic_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SplitComplimentaryPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ID" },
                values: new object[,]
                {
                    { 1, 6, 8, 1 },
                    { 2, 7, 9, 2 },
                    { 3, 8, 10, 3 },
                    { 4, 9, 11, 4 },
                    { 5, 10, 12, 5 },
                    { 6, 11, 1, 6 },
                    { 7, 12, 2, 7 },
                    { 8, 1, 3, 8 },
                    { 9, 2, 4, 9 },
                    { 10, 3, 5, 10 },
                    { 11, 4, 6, 11 },
                    { 12, 5, 7, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Monochromatic_ID",
                table: "Monochromatic",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_SplitComplimentaryPalettes_ID",
                table: "SplitComplimentaryPalettes",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tetradic_ID",
                table: "Tetradic",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Triadic_ID",
                table: "Triadic",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monochromatic");

            migrationBuilder.DropTable(
                name: "SplitComplimentaryPalettes");

            migrationBuilder.DropTable(
                name: "Tetradic");

            migrationBuilder.DropTable(
                name: "Triadic");
        }
    }
}
