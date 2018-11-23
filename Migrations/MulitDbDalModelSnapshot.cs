﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebEditor.DataAccessLayer;

namespace WebEditor.Migrations
{
    [DbContext(typeof(MulitDbDal))]
    partial class MulitDbDalModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("WebEditor.Models.ArtCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("aname")
                        .HasMaxLength(30);

                    b.HasKey("id");

                    b.ToTable("ArtCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.Article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtCategoryid");

                    b.Property<int?>("UserRelationshipid");

                    b.Property<string>("description")
                        .HasMaxLength(10000);

                    b.Property<string>("pname")
                        .HasMaxLength(30);

                    b.Property<int>("priority");

                    b.HasKey("id");

                    b.HasIndex("ArtCategoryid");

                    b.HasIndex("UserRelationshipid");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("WebEditor.Models.ArtReferenceImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Articleid");

                    b.Property<int?>("UserImageid");

                    b.Property<string>("url")
                        .HasMaxLength(300);

                    b.HasKey("id");

                    b.HasIndex("Articleid");

                    b.HasIndex("UserImageid");

                    b.ToTable("ArtReferenceImages");
                });

            modelBuilder.Entity("WebEditor.Models.Company", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserRelationshipId");

                    b.Property<string>("cname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("mainbusiness")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.HasIndex("UserRelationshipId")
                        .IsUnique();

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("WebEditor.Models.Industry", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Companyid");

                    b.Property<string>("iname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.ToTable("Industrys");
                });

            modelBuilder.Entity("WebEditor.Models.ProdCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("tname")
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.ToTable("ProdCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProdCategoryId");

                    b.Property<int?>("UserRelationshipid");

                    b.Property<string>("description")
                        .HasMaxLength(200);

                    b.Property<decimal>("discount");

                    b.Property<string>("image_url")
                        .HasMaxLength(200);

                    b.Property<string>("pname")
                        .HasMaxLength(30);

                    b.Property<decimal>("price");

                    b.HasKey("id");

                    b.HasIndex("ProdCategoryId");

                    b.HasIndex("UserRelationshipid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebEditor.Models.UserArtCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtCategoryid");

                    b.Property<int?>("UserRelationshipid");

                    b.HasKey("id");

                    b.HasIndex("ArtCategoryid");

                    b.HasIndex("UserRelationshipid");

                    b.ToTable("UserArtCategroys");
                });

            modelBuilder.Entity("WebEditor.Models.UserBase", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("openid")
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("phone")
                        .HasMaxLength(20);

                    b.Property<string>("uname")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.ToTable("UserBases");
                });

            modelBuilder.Entity("WebEditor.Models.UserDetial", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserBaseId");

                    b.Property<string>("nickname")
                        .HasMaxLength(10);

                    b.Property<string>("openid")
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("phone")
                        .HasMaxLength(20);

                    b.Property<string>("photo")
                        .HasMaxLength(50);

                    b.Property<string>("signatureline")
                        .HasMaxLength(200);

                    b.Property<string>("uname")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.HasIndex("UserBaseId")
                        .IsUnique();

                    b.ToTable("UserDetials");
                });

            modelBuilder.Entity("WebEditor.Models.UserFollowArtCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtCategoryid");

                    b.Property<int?>("UserRelationshipid");

                    b.HasKey("id");

                    b.HasIndex("ArtCategoryid");

                    b.HasIndex("UserRelationshipid");

                    b.ToTable("UserFollowArtCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.UserFollowProdCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProdCategoryid");

                    b.Property<int?>("UserRelationshipid");

                    b.HasKey("id");

                    b.HasIndex("ProdCategoryid");

                    b.HasIndex("UserRelationshipid");

                    b.ToTable("UserFollowProdCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.UserImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("UserRelationshipid");

                    b.Property<string>("url")
                        .HasMaxLength(300);

                    b.HasKey("id");

                    b.HasIndex("UserRelationshipid");

                    b.ToTable("UserImages");
                });

            modelBuilder.Entity("WebEditor.Models.UserProdCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProdCategoryid");

                    b.Property<int?>("UserRelationshipid");

                    b.HasKey("id");

                    b.HasIndex("ProdCategoryid");

                    b.HasIndex("UserRelationshipid");

                    b.ToTable("UserProdCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.UserRelationship", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserBaseId");

                    b.Property<string>("openid")
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("phone")
                        .HasMaxLength(20);

                    b.Property<string>("uname")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.HasIndex("UserBaseId")
                        .IsUnique();

                    b.ToTable("UserRelationships");
                });

            modelBuilder.Entity("WebEditor.Models.Article", b =>
                {
                    b.HasOne("WebEditor.Models.ArtCategory")
                        .WithMany("Articles")
                        .HasForeignKey("ArtCategoryid");

                    b.HasOne("WebEditor.Models.UserRelationship")
                        .WithMany("Articles")
                        .HasForeignKey("UserRelationshipid");
                });

            modelBuilder.Entity("WebEditor.Models.ArtReferenceImage", b =>
                {
                    b.HasOne("WebEditor.Models.Article")
                        .WithMany("ArticleReferenceImages")
                        .HasForeignKey("Articleid");

                    b.HasOne("WebEditor.Models.UserImage")
                        .WithMany("ArticleReferenceImage")
                        .HasForeignKey("UserImageid");
                });

            modelBuilder.Entity("WebEditor.Models.Company", b =>
                {
                    b.HasOne("WebEditor.Models.UserRelationship")
                        .WithOne("company")
                        .HasForeignKey("WebEditor.Models.Company", "UserRelationshipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.Industry", b =>
                {
                    b.HasOne("WebEditor.Models.Company")
                        .WithMany("Industrys")
                        .HasForeignKey("Companyid");
                });

            modelBuilder.Entity("WebEditor.Models.Product", b =>
                {
                    b.HasOne("WebEditor.Models.ProdCategory", "prodcategory")
                        .WithMany("Products")
                        .HasForeignKey("ProdCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebEditor.Models.UserRelationship")
                        .WithMany("Products")
                        .HasForeignKey("UserRelationshipid");
                });

            modelBuilder.Entity("WebEditor.Models.UserArtCategory", b =>
                {
                    b.HasOne("WebEditor.Models.ArtCategory")
                        .WithMany("UserArtCategorys")
                        .HasForeignKey("ArtCategoryid");

                    b.HasOne("WebEditor.Models.UserRelationship")
                        .WithMany("UserArticleCategorys")
                        .HasForeignKey("UserRelationshipid");
                });

            modelBuilder.Entity("WebEditor.Models.UserDetial", b =>
                {
                    b.HasOne("WebEditor.Models.UserBase", "userBase")
                        .WithOne("userdetial")
                        .HasForeignKey("WebEditor.Models.UserDetial", "UserBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.UserFollowArtCategory", b =>
                {
                    b.HasOne("WebEditor.Models.ArtCategory")
                        .WithMany("UserFollowArtCategorys")
                        .HasForeignKey("ArtCategoryid");

                    b.HasOne("WebEditor.Models.UserRelationship")
                        .WithMany("UserFollowArtCategorys")
                        .HasForeignKey("UserRelationshipid");
                });

            modelBuilder.Entity("WebEditor.Models.UserFollowProdCategory", b =>
                {
                    b.HasOne("WebEditor.Models.ProdCategory")
                        .WithMany("UserFollowProdCategorys")
                        .HasForeignKey("ProdCategoryid");

                    b.HasOne("WebEditor.Models.UserRelationship")
                        .WithMany("UserFollowProdCategorys")
                        .HasForeignKey("UserRelationshipid");
                });

            modelBuilder.Entity("WebEditor.Models.UserImage", b =>
                {
                    b.HasOne("WebEditor.Models.UserRelationship")
                        .WithMany("UserImages")
                        .HasForeignKey("UserRelationshipid");
                });

            modelBuilder.Entity("WebEditor.Models.UserProdCategory", b =>
                {
                    b.HasOne("WebEditor.Models.ProdCategory")
                        .WithMany("UserProdCategorys")
                        .HasForeignKey("ProdCategoryid");

                    b.HasOne("WebEditor.Models.UserRelationship")
                        .WithMany("UserProductCategorys")
                        .HasForeignKey("UserRelationshipid");
                });

            modelBuilder.Entity("WebEditor.Models.UserRelationship", b =>
                {
                    b.HasOne("WebEditor.Models.UserBase", "userBase")
                        .WithOne("userrelationship")
                        .HasForeignKey("WebEditor.Models.UserRelationship", "UserBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}