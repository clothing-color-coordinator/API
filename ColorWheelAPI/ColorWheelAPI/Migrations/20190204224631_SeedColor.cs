using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class SeedColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ColorName = table.Column<string>(nullable: true),
                    HexCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ID", "ColorName", "HexCode" },
                values: new object[,]
                {
                    { 1, "Yellow", "#FEFE33" },
                    { 2, "Yellow-Green", "#B2D732" },
                    { 3, "Green", "#66B032" },
                    { 4, "Blue-Green", "#347C98" },
                    { 5, "Blue", "#0247FE" },
                    { 6, "Blue-Violet", "#4424D6" },
                    { 7, "Violet", "#8601AF" },
                    { 8, "Red-Violet", "#C21460" },
                    { 9, "Red", "#FE2712" },
                    { 10, "Red-Orange", "#FC600A" },
                    { 11, "Orange", "#FB9902" },
                    { 12, "Yellow-Orange", "#FCCC1A" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colors");
        }
    }
}
