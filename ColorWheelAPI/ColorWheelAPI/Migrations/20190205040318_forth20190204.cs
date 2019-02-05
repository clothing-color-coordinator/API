using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorWheelAPI.Migrations
{
    public partial class forth20190204 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnalogousPalettes_Colors_ID",
                table: "AnalogousPalettes");

            migrationBuilder.DropForeignKey(
                name: "FK_ComplimentaryPalettes_Colors_ID",
                table: "ComplimentaryPalettes");

            migrationBuilder.DropForeignKey(
                name: "FK_SplitComplimentaryPalettes_Colors_ID",
                table: "SplitComplimentaryPalettes");

            migrationBuilder.DropForeignKey(
                name: "FK_TetradicPalettes_Colors_ID",
                table: "TetradicPalettes");

            migrationBuilder.DropForeignKey(
                name: "FK_TriadicPalettes_Colors_ID",
                table: "TriadicPalettes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TriadicPalettes",
                table: "TriadicPalettes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TetradicPalettes",
                table: "TetradicPalettes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SplitComplimentaryPalettes",
                table: "SplitComplimentaryPalettes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComplimentaryPalettes",
                table: "ComplimentaryPalettes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnalogousPalettes",
                table: "AnalogousPalettes");

            migrationBuilder.RenameTable(
                name: "TriadicPalettes",
                newName: "Triadic");

            migrationBuilder.RenameTable(
                name: "TetradicPalettes",
                newName: "Tetradic");

            migrationBuilder.RenameTable(
                name: "SplitComplimentaryPalettes",
                newName: "SplitComplimentary");

            migrationBuilder.RenameTable(
                name: "ComplimentaryPalettes",
                newName: "Complimentary");

            migrationBuilder.RenameTable(
                name: "AnalogousPalettes",
                newName: "Analogous");

            migrationBuilder.RenameIndex(
                name: "IX_TriadicPalettes_ID",
                table: "Triadic",
                newName: "IX_Triadic_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TetradicPalettes_ID",
                table: "Tetradic",
                newName: "IX_Tetradic_ID");

            migrationBuilder.RenameIndex(
                name: "IX_SplitComplimentaryPalettes_ID",
                table: "SplitComplimentary",
                newName: "IX_SplitComplimentary_ID");

            migrationBuilder.RenameIndex(
                name: "IX_ComplimentaryPalettes_ID",
                table: "Complimentary",
                newName: "IX_Complimentary_ID");

            migrationBuilder.RenameIndex(
                name: "IX_AnalogousPalettes_ID",
                table: "Analogous",
                newName: "IX_Analogous_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Triadic",
                table: "Triadic",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tetradic",
                table: "Tetradic",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SplitComplimentary",
                table: "SplitComplimentary",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complimentary",
                table: "Complimentary",
                columns: new[] { "ColorOneID", "ColorTwoID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Analogous",
                table: "Analogous",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Analogous_Colors_ID",
                table: "Analogous",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complimentary_Colors_ID",
                table: "Complimentary",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SplitComplimentary_Colors_ID",
                table: "SplitComplimentary",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tetradic_Colors_ID",
                table: "Tetradic",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Triadic_Colors_ID",
                table: "Triadic",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analogous_Colors_ID",
                table: "Analogous");

            migrationBuilder.DropForeignKey(
                name: "FK_Complimentary_Colors_ID",
                table: "Complimentary");

            migrationBuilder.DropForeignKey(
                name: "FK_SplitComplimentary_Colors_ID",
                table: "SplitComplimentary");

            migrationBuilder.DropForeignKey(
                name: "FK_Tetradic_Colors_ID",
                table: "Tetradic");

            migrationBuilder.DropForeignKey(
                name: "FK_Triadic_Colors_ID",
                table: "Triadic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Triadic",
                table: "Triadic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tetradic",
                table: "Tetradic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SplitComplimentary",
                table: "SplitComplimentary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complimentary",
                table: "Complimentary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Analogous",
                table: "Analogous");

            migrationBuilder.RenameTable(
                name: "Triadic",
                newName: "TriadicPalettes");

            migrationBuilder.RenameTable(
                name: "Tetradic",
                newName: "TetradicPalettes");

            migrationBuilder.RenameTable(
                name: "SplitComplimentary",
                newName: "SplitComplimentaryPalettes");

            migrationBuilder.RenameTable(
                name: "Complimentary",
                newName: "ComplimentaryPalettes");

            migrationBuilder.RenameTable(
                name: "Analogous",
                newName: "AnalogousPalettes");

            migrationBuilder.RenameIndex(
                name: "IX_Triadic_ID",
                table: "TriadicPalettes",
                newName: "IX_TriadicPalettes_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Tetradic_ID",
                table: "TetradicPalettes",
                newName: "IX_TetradicPalettes_ID");

            migrationBuilder.RenameIndex(
                name: "IX_SplitComplimentary_ID",
                table: "SplitComplimentaryPalettes",
                newName: "IX_SplitComplimentaryPalettes_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Complimentary_ID",
                table: "ComplimentaryPalettes",
                newName: "IX_ComplimentaryPalettes_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Analogous_ID",
                table: "AnalogousPalettes",
                newName: "IX_AnalogousPalettes_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TriadicPalettes",
                table: "TriadicPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TetradicPalettes",
                table: "TetradicPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID", "ColorFourID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SplitComplimentaryPalettes",
                table: "SplitComplimentaryPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComplimentaryPalettes",
                table: "ComplimentaryPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnalogousPalettes",
                table: "AnalogousPalettes",
                columns: new[] { "ColorOneID", "ColorTwoID", "ColorThreeID" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnalogousPalettes_Colors_ID",
                table: "AnalogousPalettes",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComplimentaryPalettes_Colors_ID",
                table: "ComplimentaryPalettes",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SplitComplimentaryPalettes_Colors_ID",
                table: "SplitComplimentaryPalettes",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TetradicPalettes_Colors_ID",
                table: "TetradicPalettes",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TriadicPalettes_Colors_ID",
                table: "TriadicPalettes",
                column: "ID",
                principalTable: "Colors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
