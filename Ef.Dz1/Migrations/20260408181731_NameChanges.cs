using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef.Dz1.Migrations
{
    /// <inheritdoc />
    public partial class NameChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Gangsta's Paradise");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Faygo");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Gangsta's Paradise");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "C01234");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "C56789");

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Gangstas Paradise");
        }
    }
}
