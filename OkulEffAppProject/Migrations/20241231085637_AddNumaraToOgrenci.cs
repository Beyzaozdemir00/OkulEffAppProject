using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkulEffAppProject.Migrations
{
    /// <inheritdoc />
    public partial class AddNumaraToOgrenci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Numara",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numara",
                table: "Ogrenciler");
        }
    }
}
