using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class second20190206 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complimentary");

            migrationBuilder.DropTable(
                name: "SplitComplimentary");

            migrationBuilder.CreateTable(
                name: "Complementary",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complementary", x => new { x.ColorOneID, x.ColorTwoID });
                    table.ForeignKey(
                        name: "FK_Complementary_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SplitComplementary",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ColorThreeID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SplitComplementary", x => new { x.ColorOneID, x.ColorTwoID, x.ColorThreeID });
                    table.ForeignKey(
                        name: "FK_SplitComplementary_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Complementary",
                columns: new[] { "ColorOneID", "ColorTwoID", "ID" },
                values: new object[,]
                {
                    { 1, 7, 1 },
                    { 11, 5, 11 },
                    { 10, 4, 10 },
                    { 9, 3, 9 },
                    { 8, 2, 8 },
                    { 7, 1, 7 },
                    { 12, 6, 12 },
                    { 5, 11, 5 },
                    { 4, 10, 4 },
                    { 3, 9, 3 },
                    { 2, 8, 2 },
                    { 6, 12, 6 }
                });

            migrationBuilder.InsertData(
                table: "SplitComplementary",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ID" },
                values: new object[,]
                {
                    { 10, 3, 5, 10 },
                    { 9, 2, 4, 9 },
                    { 8, 1, 3, 8 },
                    { 7, 12, 2, 7 },
                    { 6, 11, 1, 6 },
                    { 4, 9, 11, 4 },
                    { 3, 8, 10, 3 },
                    { 2, 7, 9, 2 },
                    { 1, 6, 8, 1 },
                    { 11, 4, 6, 11 },
                    { 5, 10, 12, 5 },
                    { 12, 5, 7, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complementary_ID",
                table: "Complementary",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_SplitComplementary_ID",
                table: "SplitComplementary",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complementary");

            migrationBuilder.DropTable(
                name: "SplitComplementary");

            migrationBuilder.CreateTable(
                name: "Complimentary",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complimentary", x => new { x.ColorOneID, x.ColorTwoID });
                    table.ForeignKey(
                        name: "FK_Complimentary_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SplitComplimentary",
                columns: table => new
                {
                    ColorOneID = table.Column<int>(nullable: false),
                    ColorTwoID = table.Column<int>(nullable: false),
                    ColorThreeID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SplitComplimentary", x => new { x.ColorOneID, x.ColorTwoID, x.ColorThreeID });
                    table.ForeignKey(
                        name: "FK_SplitComplimentary_Colors_ID",
                        column: x => x.ID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Complimentary",
                columns: new[] { "ColorOneID", "ColorTwoID", "ID" },
                values: new object[,]
                {
                    { 1, 7, 1 },
                    { 11, 5, 11 },
                    { 10, 4, 10 },
                    { 9, 3, 9 },
                    { 8, 2, 8 },
                    { 7, 1, 7 },
                    { 12, 6, 12 },
                    { 5, 11, 5 },
                    { 4, 10, 4 },
                    { 3, 9, 3 },
                    { 2, 8, 2 },
                    { 6, 12, 6 }
                });

            migrationBuilder.InsertData(
                table: "SplitComplimentary",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ID" },
                values: new object[,]
                {
                    { 10, 3, 5, 10 },
                    { 9, 2, 4, 9 },
                    { 8, 1, 3, 8 },
                    { 7, 12, 2, 7 },
                    { 6, 11, 1, 6 },
                    { 4, 9, 11, 4 },
                    { 3, 8, 10, 3 },
                    { 2, 7, 9, 2 },
                    { 1, 6, 8, 1 },
                    { 11, 4, 6, 11 },
                    { 5, 10, 12, 5 },
                    { 12, 5, 7, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complimentary_ID",
                table: "Complimentary",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_SplitComplimentary_ID",
                table: "SplitComplimentary",
                column: "ID");
        }
    }
}
