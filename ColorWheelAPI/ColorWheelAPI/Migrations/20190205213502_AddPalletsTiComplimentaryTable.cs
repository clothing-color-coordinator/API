using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class AddPalletsTiComplimentaryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Complimentary",
                columns: new[] { "ColorOneID", "ColorTwoID", "ID" },
                values: new object[,]
                {
                    { 7, 1, 7 },
                    { 8, 2, 8 },
                    { 9, 3, 9 },
                    { 10, 4, 10 },
                    { 11, 5, 11 },
                    { 12, 6, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Complimentary",
                keyColumns: new[] { "ColorOneID", "ColorTwoID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "Complimentary",
                keyColumns: new[] { "ColorOneID", "ColorTwoID" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "Complimentary",
                keyColumns: new[] { "ColorOneID", "ColorTwoID" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "Complimentary",
                keyColumns: new[] { "ColorOneID", "ColorTwoID" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Complimentary",
                keyColumns: new[] { "ColorOneID", "ColorTwoID" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "Complimentary",
                keyColumns: new[] { "ColorOneID", "ColorTwoID" },
                keyValues: new object[] { 12, 6 });
        }
    }
}
