using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEditor.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url",
                table: "ArtRefImages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "ArtRefImages",
                maxLength: 300,
                nullable: true);
        }
    }
}
