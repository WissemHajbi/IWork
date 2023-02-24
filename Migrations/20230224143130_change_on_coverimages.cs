using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWork.Migrations
{
    /// <inheritdoc />
    public partial class change_on_coverimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoverImage",
                value: "images/trip1.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CoverImage",
                value: "images/trip1.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CoverImage",
                value: "images/trip1.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CoverImage",
                value: "images/trip2.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CoverImage",
                value: "images/trip2.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CoverImage",
                value: "images/trip2.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CoverImage",
                value: "images/fss-logo.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CoverImage",
                value: "images/fss-logo.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CoverImage",
                value: "images/fss-logo.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CoverImage",
                value: "images/fss-logo.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CoverImage",
                value: "images/fss-logo.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CoverImage",
                value: "images/fss-logo.png");
        }
    }
}
