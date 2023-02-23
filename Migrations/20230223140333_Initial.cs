using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWork.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Field = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "Description", "Email", "Field", "Name" },
                values: new object[] { 1, "this is a dumb text description for development gangy", "society1@Gmail.com", "Education", "society number 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employers");
        }
    }
}
