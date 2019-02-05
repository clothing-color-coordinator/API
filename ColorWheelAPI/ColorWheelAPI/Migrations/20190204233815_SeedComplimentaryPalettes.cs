using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class SeedComplimentaryPalettes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComplimentaryPalettes",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplimentaryPalettes", x => new { x.ColorOneID, x.ColorTwoID });
                    table.ForeignKey(
                        name: "FK_ComplimentaryPalettes_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ComplimentaryPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ID" },
                values: new object[,]
                {
                    { 1, 7, 1 },
                    { 2, 8, 2 },
                    { 3, 9, 3 },
                    { 4, 10, 4 },
                    { 5, 11, 5 },
                    { 6, 12, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplimentaryPalettes_ID",
                table: "ComplimentaryPalettes",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplimentaryPalettes");
        }
    }
}
