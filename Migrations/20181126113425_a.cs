using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEditor.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtCategorys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProdCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdCategorys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UImages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    url = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UImages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserBases",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    openid = table.Column<string>(maxLength: 50, nullable: true),
                    name = table.Column<string>(maxLength: 10, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false),
                    phone = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBases", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(maxLength: 30, nullable: true),
                    description = table.Column<string>(maxLength: 10000, nullable: true),
                    priority = table.Column<int>(nullable: false),
                    artCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Articles_ArtCategorys_artCategoryId",
                        column: x => x.artCategoryId,
                        principalTable: "ArtCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(maxLength: 30, nullable: true),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    price = table.Column<decimal>(nullable: false),
                    discount = table.Column<decimal>(nullable: false),
                    image_url = table.Column<string>(maxLength: 200, nullable: true),
                    prodCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_ProdCategorys_prodCategoryId",
                        column: x => x.prodCategoryId,
                        principalTable: "ProdCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    mainBusiness = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: false),
                    userBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.id);
                    table.ForeignKey(
                        name: "FK_Companys_UserBases_userBaseId",
                        column: x => x.userBaseId,
                        principalTable: "UserBases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UArtCategroys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    artCategoryId = table.Column<int>(nullable: false),
                    userBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UArtCategroys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UArtCategroys_ArtCategorys_artCategoryId",
                        column: x => x.artCategoryId,
                        principalTable: "ArtCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UArtCategroys_UserBases_userBaseId",
                        column: x => x.userBaseId,
                        principalTable: "UserBases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UFolwArtCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ArtCategoryId = table.Column<int>(nullable: false),
                    userBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UFolwArtCategorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UFolwArtCategorys_ArtCategorys_ArtCategoryId",
                        column: x => x.ArtCategoryId,
                        principalTable: "ArtCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UFolwArtCategorys_UserBases_userBaseId",
                        column: x => x.userBaseId,
                        principalTable: "UserBases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UFolwProdCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    prodCategoryId = table.Column<int>(nullable: false),
                    userBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UFolwProdCategorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UFolwProdCategorys_ProdCategorys_prodCategoryId",
                        column: x => x.prodCategoryId,
                        principalTable: "ProdCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UFolwProdCategorys_UserBases_userBaseId",
                        column: x => x.userBaseId,
                        principalTable: "UserBases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UProdCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    prodCategoryId = table.Column<int>(nullable: false),
                    userBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UProdCategorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UProdCategorys_ProdCategorys_prodCategoryId",
                        column: x => x.prodCategoryId,
                        principalTable: "ProdCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UProdCategorys_UserBases_userBaseId",
                        column: x => x.userBaseId,
                        principalTable: "UserBases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetials",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    openid = table.Column<string>(maxLength: 50, nullable: true),
                    name = table.Column<string>(maxLength: 10, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false),
                    nickname = table.Column<string>(maxLength: 10, nullable: true),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    photo = table.Column<string>(maxLength: 50, nullable: true),
                    signatureline = table.Column<string>(maxLength: 200, nullable: true),
                    userBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetials", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserDetials_UserBases_userBaseId",
                        column: x => x.userBaseId,
                        principalTable: "UserBases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtRefImages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    url = table.Column<string>(maxLength: 300, nullable: true),
                    articleId = table.Column<int>(nullable: false),
                    UImageid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtRefImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArtRefImages_UImages_UImageid",
                        column: x => x.UImageid,
                        principalTable: "UImages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArtRefImages_Articles_articleId",
                        column: x => x.articleId,
                        principalTable: "Articles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Industrys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    companyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industrys", x => x.id);
                    table.ForeignKey(
                        name: "FK_Industrys_Companys_companyId",
                        column: x => x.companyId,
                        principalTable: "Companys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_artCategoryId",
                table: "Articles",
                column: "artCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtRefImages_UImageid",
                table: "ArtRefImages",
                column: "UImageid");

            migrationBuilder.CreateIndex(
                name: "IX_ArtRefImages_articleId",
                table: "ArtRefImages",
                column: "articleId");

            migrationBuilder.CreateIndex(
                name: "IX_Companys_userBaseId",
                table: "Companys",
                column: "userBaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Industrys_companyId",
                table: "Industrys",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_prodCategoryId",
                table: "Products",
                column: "prodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UArtCategroys_artCategoryId",
                table: "UArtCategroys",
                column: "artCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UArtCategroys_userBaseId",
                table: "UArtCategroys",
                column: "userBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UFolwArtCategorys_ArtCategoryId",
                table: "UFolwArtCategorys",
                column: "ArtCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UFolwArtCategorys_userBaseId",
                table: "UFolwArtCategorys",
                column: "userBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UFolwProdCategorys_prodCategoryId",
                table: "UFolwProdCategorys",
                column: "prodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UFolwProdCategorys_userBaseId",
                table: "UFolwProdCategorys",
                column: "userBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UProdCategorys_prodCategoryId",
                table: "UProdCategorys",
                column: "prodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UProdCategorys_userBaseId",
                table: "UProdCategorys",
                column: "userBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetials_userBaseId",
                table: "UserDetials",
                column: "userBaseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtRefImages");

            migrationBuilder.DropTable(
                name: "Industrys");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UArtCategroys");

            migrationBuilder.DropTable(
                name: "UFolwArtCategorys");

            migrationBuilder.DropTable(
                name: "UFolwProdCategorys");

            migrationBuilder.DropTable(
                name: "UProdCategorys");

            migrationBuilder.DropTable(
                name: "UserDetials");

            migrationBuilder.DropTable(
                name: "UImages");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "ProdCategorys");

            migrationBuilder.DropTable(
                name: "ArtCategorys");

            migrationBuilder.DropTable(
                name: "UserBases");
        }
    }
}
