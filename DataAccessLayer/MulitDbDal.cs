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
        //public DbSet<URelationship> URelationships { get; set; }
        public DbSet<ProdCategory> ProdCategorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Industry> Industrys { get; set; }
        public DbSet<ArtCategory> ArtCategorys { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArtRefImage> ArtRefImages { get; set; }
        public DbSet<UImage> UImages { get; set; }
        public DbSet<UArtCategory> UArtCategroys { get; set; }
        public DbSet<UProdCategory> UProdCategorys { get; set; }
        public DbSet<UFolwArtCategory> UFolwArtCategorys { get; set; }
        public DbSet<UFolwProdCategory> UFolwProdCategorys { get; set; }

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