using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumePortfolioSite.Migrations
{
    /// <inheritdoc />
    public partial class AddJobStartYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StartYear",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartYear",
                table: "Jobs");
        }
    }
}
