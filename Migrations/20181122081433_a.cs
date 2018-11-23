using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEditor.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    aname = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategorys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    tname = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategorys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserBases",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    openid = table.Column<string>(maxLength: 50, nullable: true),
                    uname = table.Column<string>(maxLength: 10, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false),
                    phone = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetials",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    openid = table.Column<string>(maxLength: 50, nullable: true),
                    uname = table.Column<string>(maxLength: 10, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false),
                    nickname = table.Column<string>(maxLength: 10, nullable: true),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    photo = table.Column<string>(maxLength: 50, nullable: true),
                    signatureline = table.Column<string>(maxLength: 200, nullable: true),
                    UserBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetials", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserDetials_UserBases_UserBaseId",
                        column: x => x.UserBaseId,
                        principalTable: "UserBases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    pname = table.Column<string>(maxLength: 30, nullable: true),
                    description = table.Column<string>(maxLength: 10000, nullable: true),
                    priority = table.Column<int>(nullable: false),
                    ArticleCategoryid = table.Column<int>(nullable: true),
                    UserDetialid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleCategorys_ArticleCategoryid",
                        column: x => x.ArticleCategoryid,
                        principalTable: "ArticleCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_UserDetials_UserDetialid",
                        column: x => x.UserDetialid,
                        principalTable: "UserDetials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    cname = table.Column<string>(maxLength: 50, nullable: false),
                    mainbusiness = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: false),
                    UserDetialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.id);
                    table.ForeignKey(
                        name: "FK_Companys_UserDetials_UserDetialId",
                        column: x => x.UserDetialId,
                        principalTable: "UserDetials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    pname = table.Column<string>(maxLength: 30, nullable: true),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    price = table.Column<decimal>(nullable: false),
                    discount = table.Column<decimal>(nullable: false),
                    image_url = table.Column<string>(maxLength: 200, nullable: true),
                    ProductCategoryid = table.Column<int>(nullable: true),
                    UserDetialid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategorys_ProductCategoryid",
                        column: x => x.ProductCategoryid,
                        principalTable: "ProductCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_UserDetials_UserDetialid",
                        column: x => x.UserDetialid,
                        principalTable: "UserDetials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserArticleCategroys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ArticleCategoryid = table.Column<int>(nullable: true),
                    UserDetialid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArticleCategroys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserArticleCategroys_ArticleCategorys_ArticleCategoryid",
                        column: x => x.ArticleCategoryid,
                        principalTable: "ArticleCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserArticleCategroys_UserDetials_UserDetialid",
                        column: x => x.UserDetialid,
                        principalTable: "UserDetials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserImages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    url = table.Column<string>(maxLength: 300, nullable: true),
                    UserDetialid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserImages_UserDetials_UserDetialid",
                        column: x => x.UserDetialid,
                        principalTable: "UserDetials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProductCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ProductCategoryid = table.Column<int>(nullable: true),
                    UserDetialid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProductCategorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserProductCategorys_ProductCategorys_ProductCategoryid",
                        column: x => x.ProductCategoryid,
                        principalTable: "ProductCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProductCategorys_UserDetials_UserDetialid",
                        column: x => x.UserDetialid,
                        principalTable: "UserDetials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Industrys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    iname = table.Column<string>(maxLength: 50, nullable: false),
                    Companyid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industrys", x => x.id);
                    table.ForeignKey(
                        name: "FK_Industrys_Companys_Companyid",
                        column: x => x.Companyid,
                        principalTable: "Companys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleReferenceImages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    url = table.Column<string>(maxLength: 300, nullable: true),
                    Articleid = table.Column<int>(nullable: true),
                    UserImageid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleReferenceImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArticleReferenceImages_Articles_Articleid",
                        column: x => x.Articleid,
                        principalTable: "Articles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticleReferenceImages_UserImages_UserImageid",
                        column: x => x.UserImageid,
                        principalTable: "UserImages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleReferenceImages_Articleid",
                table: "ArticleReferenceImages",
                column: "Articleid");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleReferenceImages_UserImageid",
                table: "ArticleReferenceImages",
                column: "UserImageid");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryid",
                table: "Articles",
                column: "ArticleCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserDetialid",
                table: "Articles",
                column: "UserDetialid");

            migrationBuilder.CreateIndex(
                name: "IX_Companys_UserDetialId",
                table: "Companys",
                column: "UserDetialId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Industrys_Companyid",
                table: "Industrys",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryid",
                table: "Products",
                column: "ProductCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserDetialid",
                table: "Products",
                column: "UserDetialid");

            migrationBuilder.CreateIndex(
                name: "IX_UserArticleCategroys_ArticleCategoryid",
                table: "UserArticleCategroys",
                column: "ArticleCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_UserArticleCategroys_UserDetialid",
                table: "UserArticleCategroys",
                column: "UserDetialid");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetials_UserBaseId",
                table: "UserDetials",
                column: "UserBaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserImages_UserDetialid",
                table: "UserImages",
                column: "UserDetialid");

            migrationBuilder.CreateIndex(
                name: "IX_UserProductCategorys_ProductCategoryid",
                table: "UserProductCategorys",
                column: "ProductCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_UserProductCategorys_UserDetialid",
                table: "UserProductCategorys",
                column: "UserDetialid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleReferenceImages");

            migrationBuilder.DropTable(
                name: "Industrys");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserArticleCategroys");

            migrationBuilder.DropTable(
                name: "UserProductCategorys");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "UserImages");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "ProductCategorys");

            migrationBuilder.DropTable(
                name: "ArticleCategorys");

            migrationBuilder.DropTable(
                name: "UserDetials");

            migrationBuilder.DropTable(
                name: "UserBases");
        }
    }
}
