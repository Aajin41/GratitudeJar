using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GratitudeJar.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMoodFlag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoodFlag",
                table: "Entries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoodFlag",
                table: "Entries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
