using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef.Dz1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rating",
                value: 4.2m);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rating",
                value: 3.9m);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Lyrics", "PlayCount", "Rating" },
                values: new object[] { "Some lyrics...", 1000, 4.5m });

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PlayCount", "Rating" },
                values: new object[] { 500, 3.8m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rating",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rating",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Lyrics", "PlayCount", "Rating" },
                values: new object[] { null, 0, 0m });

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PlayCount", "Rating" },
                values: new object[] { 0, 0m });
        }
    }
}
