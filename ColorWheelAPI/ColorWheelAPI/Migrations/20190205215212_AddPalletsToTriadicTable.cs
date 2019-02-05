using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class AddPalletsToTriadicTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Triadic",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ID" },
                values: new object[,]
                {
                    { 5, 9, 1, 5 },
                    { 6, 10, 2, 6 },
                    { 7, 11, 3, 7 },
                    { 8, 12, 4, 8 },
                    { 9, 1, 5, 9 },
                    { 10, 2, 6, 10 },
                    { 11, 3, 7, 11 },
                    { 12, 4, 8, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Triadic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 5, 9, 1 });

            migrationBuilder.DeleteData(
                table: "Triadic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 6, 10, 2 });

            migrationBuilder.DeleteData(
                table: "Triadic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 7, 11, 3 });

            migrationBuilder.DeleteData(
                table: "Triadic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 8, 12, 4 });

            migrationBuilder.DeleteData(
                table: "Triadic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 9, 1, 5 });

            migrationBuilder.DeleteData(
                table: "Triadic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 10, 2, 6 });

            migrationBuilder.DeleteData(
                table: "Triadic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 11, 3, 7 });

            migrationBuilder.DeleteData(
                table: "Triadic",
                keyColumns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" },
                keyValues: new object[] { 12, 4, 8 });
        }
    }
}
