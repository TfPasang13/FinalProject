using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasangT_SMS.web.Migrations
{
    /// <inheritdoc />
    public partial class CourseUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credits",
                table: "CourseInfo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Credits",
                table: "CourseInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
