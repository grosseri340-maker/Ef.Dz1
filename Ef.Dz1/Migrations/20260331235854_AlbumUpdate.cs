using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef.Dz1.Migrations
{
    /// <inheritdoc />
    public partial class AlbumUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Albums",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Albums");
        }
    }
}
