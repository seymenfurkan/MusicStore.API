using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi_Project.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "Musician", "Name" },
                values: new object[,]
                {
                    { 1, "Madrigal", "Dip" },
                    { 2, "Madrigal", "Seni Dert Etmeler" },
                    { 3, "Barış Akarsu", "Gözlerin" },
                    { 4, "Şebnem Ferah", "Gözlerimin Etrafındaki Çizgiler" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
