using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class SeedAnalogousPalettes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalogousPalettes",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ColorThreeID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalogousPalettes", x => new { x.ColorOneID, x.ColorTwoID, x.ColorThreeID });
                    table.ForeignKey(
                        name: "FK_AnalogousPalettes_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AnalogousPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ID" },
                values: new object[,]
                {
                    { 1, 2, 12, 1 },
                    { 2, 3, 1, 2 },
                    { 3, 4, 2, 3 },
                    { 4, 5, 3, 4 },
                    { 5, 6, 4, 5 },
                    { 6, 7, 5, 6 },
                    { 7, 8, 6, 7 },
                    { 8, 9, 7, 8 },
                    { 9, 10, 8, 9 },
                    { 10, 11, 9, 10 },
                    { 11, 12, 10, 11 },
                    { 12, 1, 11, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalogousPalettes_ID",
                table: "AnalogousPalettes",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalogousPalettes");
        }
    }
}
