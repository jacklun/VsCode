using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.EntityFrameworkCore;
using WebEditor.Models;

namespace WebEditor.DataAccessLayer {
    public class Dal1 : DbContext {
        public Dal1 () : base () { }
        //下一句为start.cs全局注入数据库连接的数据传输层配置
        //public Dal1 (DbContextOptions<Dal> options) : base (options) { }

        public DbSet<UserBase> UserBases { get; set; }
        public DbSet<UserDetial> UserDetials { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Product> Products { get; set; }
        /*
        public DbSet<ArticleCategory> ArticleCategorys { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Industry> Industrys { get; set; }

        public DbSet<UserArticleCategory> UserArticleCategroys { get; set; }
        public DbSet<UserProductCategory> UserProductCategorys { get; set; }
        public DbSet<ReferenceImage> ReferenceImages { get; set; }
        */
        protected override void OnConfiguring (DbContextOptionsBuilder optionBuilder) {
            //数据传输层使用单数据库时，可以仅在此注入数据库连接，其他地方无需改动
            //相应传输层的构造器也无参：public Dal1 () : base () { }

            var config = new ConfigurationBuilder ()
                .SetBasePath (System.IO.Directory.GetCurrentDirectory ())
                .AddJsonFile ("appsettings.Development.json")
                .Build ();

            optionBuilder.UseMySQL (config.GetConnectionString ("mysql1"));

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