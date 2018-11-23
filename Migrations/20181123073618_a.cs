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
                    aname = table.Column<string>(maxLength: 30, nullable: true)
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
                    tname = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdCategorys", x => x.id);
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
                name: "UserRelationships",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    openid = table.Column<string>(maxLength: 50, nullable: true),
                    uname = table.Column<string>(maxLength: 10, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    UserBaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRelationships", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserRelationships_UserBases_UserBaseId",
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
                    ArtCategoryid = table.Column<int>(nullable: true),
                    UserRelationshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Articles_ArtCategorys_ArtCategoryid",
                        column: x => x.ArtCategoryid,
                        principalTable: "ArtCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_UserRelationships_UserRelationshipid",
                        column: x => x.UserRelationshipid,
                        principalTable: "UserRelationships",
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
                    UserRelationshipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.id);
                    table.ForeignKey(
                        name: "FK_Companys_UserRelationships_UserRelationshipId",
                        column: x => x.UserRelationshipId,
                        principalTable: "UserRelationships",
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
                    ProdCategoryId = table.Column<int>(nullable: false),
                    UserRelationshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_ProdCategorys_ProdCategoryId",
                        column: x => x.ProdCategoryId,
                        principalTable: "ProdCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_UserRelationships_UserRelationshipid",
                        column: x => x.UserRelationshipid,
                        principalTable: "UserRelationships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserArtCategroys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ArtCategoryid = table.Column<int>(nullable: true),
                    UserRelationshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArtCategroys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserArtCategroys_ArtCategorys_ArtCategoryid",
                        column: x => x.ArtCategoryid,
                        principalTable: "ArtCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserArtCategroys_UserRelationships_UserRelationshipid",
                        column: x => x.UserRelationshipid,
                        principalTable: "UserRelationships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFollowArtCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ArtCategoryid = table.Column<int>(nullable: true),
                    UserRelationshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollowArtCategorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserFollowArtCategorys_ArtCategorys_ArtCategoryid",
                        column: x => x.ArtCategoryid,
                        principalTable: "ArtCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFollowArtCategorys_UserRelationships_UserRelationshipid",
                        column: x => x.UserRelationshipid,
                        principalTable: "UserRelationships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFollowProdCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ProdCategoryid = table.Column<int>(nullable: true),
                    UserRelationshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollowProdCategorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserFollowProdCategorys_ProdCategorys_ProdCategoryid",
                        column: x => x.ProdCategoryid,
                        principalTable: "ProdCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFollowProdCategorys_UserRelationships_UserRelationshipid",
                        column: x => x.UserRelationshipid,
                        principalTable: "UserRelationships",
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
                    UserRelationshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserImages_UserRelationships_UserRelationshipid",
                        column: x => x.UserRelationshipid,
                        principalTable: "UserRelationships",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProdCategorys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ProdCategoryid = table.Column<int>(nullable: true),
                    UserRelationshipid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProdCategorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserProdCategorys_ProdCategorys_ProdCategoryid",
                        column: x => x.ProdCategoryid,
                        principalTable: "ProdCategorys",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserProdCategorys_UserRelationships_UserRelationshipid",
                        column: x => x.UserRelationshipid,
                        principalTable: "UserRelationships",
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
                name: "ArtReferenceImages",
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
                    table.PrimaryKey("PK_ArtReferenceImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArtReferenceImages_Articles_Articleid",
                        column: x => x.Articleid,
                        principalTable: "Articles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArtReferenceImages_UserImages_UserImageid",
                        column: x => x.UserImageid,
                        principalTable: "UserImages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArtCategoryid",
                table: "Articles",
                column: "ArtCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserRelationshipid",
                table: "Articles",
                column: "UserRelationshipid");

            migrationBuilder.CreateIndex(
                name: "IX_ArtReferenceImages_Articleid",
                table: "ArtReferenceImages",
                column: "Articleid");

            migrationBuilder.CreateIndex(
                name: "IX_ArtReferenceImages_UserImageid",
                table: "ArtReferenceImages",
                column: "UserImageid");

            migrationBuilder.CreateIndex(
                name: "IX_Companys_UserRelationshipId",
                table: "Companys",
                column: "UserRelationshipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Industrys_Companyid",
                table: "Industrys",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProdCategoryId",
                table: "Products",
                column: "ProdCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserRelationshipid",
                table: "Products",
                column: "UserRelationshipid");

            migrationBuilder.CreateIndex(
                name: "IX_UserArtCategroys_ArtCategoryid",
                table: "UserArtCategroys",
                column: "ArtCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_UserArtCategroys_UserRelationshipid",
                table: "UserArtCategroys",
                column: "UserRelationshipid");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetials_UserBaseId",
                table: "UserDetials",
                column: "UserBaseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowArtCategorys_ArtCategoryid",
                table: "UserFollowArtCategorys",
                column: "ArtCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowArtCategorys_UserRelationshipid",
                table: "UserFollowArtCategorys",
                column: "UserRelationshipid");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowProdCategorys_ProdCategoryid",
                table: "UserFollowProdCategorys",
                column: "ProdCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowProdCategorys_UserRelationshipid",
                table: "UserFollowProdCategorys",
                column: "UserRelationshipid");

            migrationBuilder.CreateIndex(
                name: "IX_UserImages_UserRelationshipid",
                table: "UserImages",
                column: "UserRelationshipid");

            migrationBuilder.CreateIndex(
                name: "IX_UserProdCategorys_ProdCategoryid",
                table: "UserProdCategorys",
                column: "ProdCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_UserProdCategorys_UserRelationshipid",
                table: "UserProdCategorys",
                column: "UserRelationshipid");

            migrationBuilder.CreateIndex(
                name: "IX_UserRelationships_UserBaseId",
                table: "UserRelationships",
                column: "UserBaseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtReferenceImages");

            migrationBuilder.DropTable(
                name: "Industrys");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserArtCategroys");

            migrationBuilder.DropTable(
                name: "UserDetials");

            migrationBuilder.DropTable(
                name: "UserFollowArtCategorys");

            migrationBuilder.DropTable(
                name: "UserFollowProdCategorys");

            migrationBuilder.DropTable(
                name: "UserProdCategorys");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "UserImages");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "ProdCategorys");

            migrationBuilder.DropTable(
                name: "ArtCategorys");

            migrationBuilder.DropTable(
                name: "UserRelationships");

            migrationBuilder.DropTable(
                name: "UserBases");
        }
    }
}
