using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IWork.Migrations
{
    /// <inheritdoc />
    public partial class examples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoverImage",
                value: "images/fss-logo.png");

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "CoverImage", "Description", "Email", "Field", "Image1", "Image2", "Name" },
                values: new object[,]
                {
                    { 2, "images/fss-logo.png", "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "", "", "society number 2" },
                    { 3, "images/fss-logo.png", "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "", "", "society number 3" },
                    { 4, "images/fss-logo.png", "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "", "", "society number 4" },
                    { 5, "images/fss-logo.png", "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "", "", "society number 5" },
                    { 6, "images/fss-logo.png", "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "", "", "society number 6" },
                    { 7, "images/fss-logo.png", "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "", "", "society number 7" },
                    { 8, "images/fss-logo.png", "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "", "", "society number 8" },
                    { 9, "images/fss-logo.png", "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "", "", "society number 9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CoverImage",
                value: "imagesss-logo.png");
        }
    }
}
