using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class AddPalletsToTetradicTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tetradic",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID", "ID" },
                values: new object[,]
                {
                    { 7, 1, 9, 3, 7 },
                    { 8, 2, 10, 4, 8 },
                    { 9, 3, 11, 5, 9 },
                    { 10, 4, 12, 6, 10 },
                    { 11, 5, 1, 7, 11 },
                    { 12, 6, 2, 8, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tetradic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 7, 1, 9, 3 });

            migrationBuilder.DeleteData(
                table: "Tetradic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 8, 2, 10, 4 });

            migrationBuilder.DeleteData(
                table: "Tetradic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 9, 3, 11, 5 });

            migrationBuilder.DeleteData(
                table: "Tetradic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 10, 4, 12, 6 });

            migrationBuilder.DeleteData(
                table: "Tetradic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 11, 5, 1, 7 });

            migrationBuilder.DeleteData(
                table: "Tetradic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" },
                keyValues: new object[] { 12, 6, 2, 8 });
        }
    }
}
