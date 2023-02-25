using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWork.Migrations
{
    /// <inheritdoc />
    public partial class Change_employersmodel_and_new_applymodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FPTime",
                table: "Employers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Employers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Applys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Prename = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Experience = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applys", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverImage", "FPTime", "Image1", "Image2", "StartDate" },
                values: new object[] { "/images/fss-logo.png", "Full Time", "/images/fss1.png", "/images/fss1.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverImage", "FPTime", "StartDate" },
                values: new object[] { "/images/fss-logo.png", "Part Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverImage", "FPTime", "StartDate" },
                values: new object[] { "/images/fss-logo.png", "Full Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverImage", "FPTime", "StartDate" },
                values: new object[] { "/images/trip1.png", "Full Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoverImage", "FPTime", "StartDate" },
                values: new object[] { "/images/trip1.png", "Full Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoverImage", "FPTime", "StartDate" },
                values: new object[] { "/images/trip1.png", "Full Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CoverImage", "FPTime", "StartDate" },
                values: new object[] { "/images/trip2.png", "Full Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CoverImage", "FPTime", "StartDate" },
                values: new object[] { "/images/trip2.png", "Full Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CoverImage", "FPTime", "StartDate" },
                values: new object[] { "/images/trip2.png", "Full Time", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applys");

            migrationBuilder.DropColumn(
                name: "FPTime",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Employers");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverImage", "Image1", "Image2" },
                values: new object[] { "images/fss-logo.png", "", "" });

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CoverImage",
                value: "images/fss-logo.png");

            migrationBuilder.UpdateData(
                table: "Employers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CoverImage",
                value: "images/fss-logo.png");

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
    }
}
