using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePortfolioSite.Migrations
{
    /// <inheritdoc />
    public partial class AddskillExperienceLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExperienceLevel",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExperienceLevel",
                table: "Skills");
        }
    }
}
