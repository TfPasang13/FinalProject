using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasangT_SMS.web.Migrations
{
    /// <inheritdoc />
    public partial class StudentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "AspNetUsers",
                type: "int",
                maxLength: 255,
                nullable: false,
                defaultValue: 0);
        }
    }
}
