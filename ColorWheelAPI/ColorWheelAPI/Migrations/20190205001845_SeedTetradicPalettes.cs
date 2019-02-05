using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class SeedTetradicPalettes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tetradic_Colors_ID",
                table: "Tetradic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tetradic",
                table: "Tetradic");

            migrationBuilder.RenameTable(
                name: "Tetradic",
                newName: "TetradicPalettes");

            migrationBuilder.RenameIndex(
                name: "IX_Tetradic_ID",
                table: "TetradicPalettes",
                newName: "IX_TetradicPalettes_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TetradicPalettes",
                table: "TetradicPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" });

            migrationBuilder.InsertData(
                table: "TetradicPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID", "ID" },
                values: new object[,]
                {
                    { 1, 7, 3, 9, 1 },
                    { 2, 8, 4, 10, 2 },
                    { 3, 9, 5, 11, 3 },
                    { 4, 10, 6, 12, 4 },
                    { 5, 11, 7, 1, 5 },
                    { 6, 12, 8, 2, 6 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TetradicPalettes_Colors_ID",
                table: "TetradicPalettes",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TetradicPalettes_Colors_ID",
                table: "TetradicPalettes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TetradicPalettes",
                table: "TetradicPalettes");

            migrationBuilder.DeleteData(
                table: "TetradicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 1, 7, 3, 9 });

            migrationBuilder.DeleteData(
                table: "TetradicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 2, 8, 4, 10 });

            migrationBuilder.DeleteData(
                table: "TetradicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 3, 9, 5, 11 });

            migrationBuilder.DeleteData(
                table: "TetradicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 4, 10, 6, 12 });

            migrationBuilder.DeleteData(
                table: "TetradicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 5, 11, 7, 1 });

            migrationBuilder.DeleteData(
                table: "TetradicPalettes",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 6, 12, 8, 2 });

            migrationBuilder.RenameTable(
                name: "TetradicPalettes",
                newName: "Tetradic");

            migrationBuilder.RenameIndex(
                name: "IX_TetradicPalettes_ID",
                table: "Tetradic",
                newName: "IX_Tetradic_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tetradic",
                table: "Tetradic",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tetradic_Colors_ID",
                table: "Tetradic",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
