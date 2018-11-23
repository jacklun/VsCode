using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.EntityFrameworkCore;
using WebEditor.Models;

namespace WebEditor.DataAccessLayer {
    public class MulitDbDal : DbContext {
        //public Dal () : base () { }
        public MulitDbDal (DbContextOptions<MulitDbDal> options) : base (options) {
            //Database.Migrate();
        }

        public DbSet<UserBase> UserBases { get; set; }
        public DbSet<UserDetial> UserDetials { get; set; }
        public DbSet<UserRelationship> UserRelationships { get; set; }
        public DbSet<ProdCategory> ProdCategorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Industry> Industrys { get; set; }
        public DbSet<ArtCategory> ArtCategorys { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArtReferenceImage> ArtReferenceImages { get; set; }
        public DbSet<UserImage> UserImages { get; set; }
        public DbSet<UserArtCategory> UserArtCategroys { get; set; }
        public DbSet<UserProdCategory> UserProdCategorys { get; set; }
        public DbSet<UserFollowArtCategory> UserFollowArtCategorys { get; set; }
        public DbSet<UserFollowProdCategory> UserFollowProdCategorys { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionBuilder) {
            /*
            var config = new ConfigurationBuilder ()
                .SetBasePath (System.IO.Directory.GetCurrentDirectory ())
                .AddJsonFile ("appsettings.Development.json")
                .Build ();

            optionBuilder.UseMySQL (config.GetConnectionString ("mysql"));
            */
            base.OnConfiguring (optionBuilder);
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            //modelBuilder.Entity<Product>().ToTable("Products");
            //modelBuilder.Entity<ProductType>().ToTable("ProductTypes");
            //modelBuilder.Entity<UserInfo>().ToTable("UserInfos");

            base.OnModelCreating (modelBuilder);
        }
    }
}