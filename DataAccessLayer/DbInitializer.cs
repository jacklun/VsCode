using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.EntityFrameworkCore;
using WebEditor.Models;

namespace WebEditor.DataAccessLayer {
    public class DbInitializer {
        public static void Initialize (Dal context) {
            //context.Database.EnsureCreated();
            /*
            // Look for any Products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var Products = new Product[]
            {
                new Product{tid=1,pname="Alexander",price=11M,discount=8.0M,image_url="/Images/UploadImages/f6645437-34ce-4994-b56f-640cb4d8d0d8.jpg"},
                new Product{tid=1,pname="Alonso",price=11M,discount=8.0M,image_url="/Images/UploadImages/f6645437-34ce-4994-b56f-640cb4d8d0d8.jpg"},
                new Product{tid=2,pname="Anand",price=12M,discount=8.0M,image_url="/Images/UploadImages/f6645437-34ce-4994-b56f-640cb4d8d0d8.jpg"},
                new Product{tid=2,pname="Barzdukas",price=12M,discount=8.0M,image_url="/Images/UploadImages/f6645437-34ce-4994-b56f-640cb4d8d0d8.jpg"},
                new Product{tid=3,pname="Li",price=14M,discount=8.0M,image_url="/Images/UploadImages/f6645437-34ce-4994-b56f-640cb4d8d0d8.jpg"},
                new Product{tid=3,pname="Justice",price=14M,discount=8.0M,image_url="/Images/UploadImages/f6645437-34ce-4994-b56f-640cb4d8d0d8.jpg"},
                new Product{tid=4,pname="Norman",price=16M,discount=8.0M,image_url="/Images/UploadImages/f6645437-34ce-4994-b56f-640cb4d8d0d8.jpg"},
                new Product{tid=4,pname="Olivetto",price=16M,discount=8.0M,image_url="/Images/UploadImages/f6645437-34ce-4994-b56f-640cb4d8d0d8.jpg"}
            };
            foreach (Product p in Products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            var ProductTypes = new ProductType[]
            {
                new ProductType{tname="Chemistry"},
                new ProductType{tname="Microeconomics"},
                new ProductType{tname="Macroeconomics"},
                new ProductType{tname="Calculus"},
            };
            foreach (ProductType pt in ProductTypes)
            {
                context.ProductTypes.Add(pt);
            }
            context.SaveChanges();

            var UserInfos = new UserInfo[]
            {
                new UserInfo{uname="admin",password="123456"},
            };
            foreach (UserInfo u in UserInfos)
            {
                context.UserInfos.Add(u);
            }
            context.SaveChanges();
            */
        }
    }
}