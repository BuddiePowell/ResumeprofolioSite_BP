using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePortfolioSite.Migrations
{
    /// <inheritdoc />
    public partial class AddJobPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Jobs");
        }
    }
}
