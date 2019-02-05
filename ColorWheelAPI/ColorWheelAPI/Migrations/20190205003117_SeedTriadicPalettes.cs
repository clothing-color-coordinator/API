using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class SeedTriadicPalettes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Triadic_Colors_ID",
                table: "Triadic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Triadic",
                table: "Triadic");

            migrationBuilder.RenameTable(
                name: "Triadic",
                newName: "TriadicPalettes");

            migrationBuilder.RenameIndex(
                name: "IX_Triadic_ID",
                table: "TriadicPalettes",
                newName: "IX_TriadicPalettes_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TriadicPalettes",
                table: "TriadicPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" });

            migrationBuilder.InsertData(
                table: "TriadicPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ID" },
                values: new object[,]
                {
                    { 1, 5, 9, 1 },
                    { 2, 6, 10, 2 },
                    { 3, 7, 11, 3 },
                    { 4, 8, 12, 4 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TriadicPalettes_Colors_ID",
                table: "TriadicPalettes",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TriadicPalettes_Colors_ID",
                table: "TriadicPalettes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TriadicPalettes",
                table: "TriadicPalettes");

            migrationBuilder.DeleteData(
                table: "TriadicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 1, 5, 9 });

            migrationBuilder.DeleteData(
                table: "TriadicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 2, 6, 10 });

            migrationBuilder.DeleteData(
                table: "TriadicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 3, 7, 11 });

            migrationBuilder.DeleteData(
                table: "TriadicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 4, 8, 12 });

            migrationBuilder.RenameTable(
                name: "TriadicPalettes",
                newName: "Triadic");

            migrationBuilder.RenameIndex(
                name: "IX_TriadicPalettes_ID",
                table: "Triadic",
                newName: "IX_Triadic_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Triadic",
                table: "Triadic",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Triadic_Colors_ID",
                table: "Triadic",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
