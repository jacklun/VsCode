using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEditor.Migrations
{
    public partial class c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url",
                table: "UImages");

            migrationBuilder.AddColumn<int>(
                name: "imageId",
                table: "UImages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userBaseId",
                table: "UImages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    url = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UImages_imageId",
                table: "UImages",
                column: "imageId");

            migrationBuilder.CreateIndex(
                name: "IX_UImages_userBaseId",
                table: "UImages",
                column: "userBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_UImages_Image_imageId",
                table: "UImages",
                column: "imageId",
                principalTable: "Image",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UImages_UserBases_userBaseId",
                table: "UImages",
                column: "userBaseId",
                principalTable: "UserBases",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UImages_Image_imageId",
                table: "UImages");

            migrationBuilder.DropForeignKey(
                name: "FK_UImages_UserBases_userBaseId",
                table: "UImages");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropIndex(
                name: "IX_UImages_imageId",
                table: "UImages");

            migrationBuilder.DropIndex(
                name: "IX_UImages_userBaseId",
                table: "UImages");

            migrationBuilder.DropColumn(
                name: "imageId",
                table: "UImages");

            migrationBuilder.DropColumn(
                name: "userBaseId",
                table: "UImages");

            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "UImages",
                maxLength: 300,
                nullable: true);
        }
    }
}
