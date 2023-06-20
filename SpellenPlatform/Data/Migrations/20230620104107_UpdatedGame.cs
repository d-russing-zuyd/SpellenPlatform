using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpellenPlatform.Data.Migrations
{
    public partial class UpdatedGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLink",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLink",
                table: "Games");
        }
    }
}
