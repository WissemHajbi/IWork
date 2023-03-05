using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWork.Migrations
{
    /// <inheritdoc />
    public partial class Eductaion_adresse__ApplyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Applys",
                table: "Applys");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Applys",
                newName: "Education");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Applys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Applys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Adresse",
                table: "Applys",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applys",
                table: "Applys",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Applys",
                table: "Applys");

            migrationBuilder.DropColumn(
                name: "Adresse",
                table: "Applys");

            migrationBuilder.RenameColumn(
                name: "Education",
                table: "Applys",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Applys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Applys",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applys",
                table: "Applys",
                column: "Id");
        }
    }
}
