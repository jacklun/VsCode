using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.BusinessLayer {
    public class UserInfoBL {
        private readonly MulitDbDal dal;
        private readonly HttpContext http_context;

        public UserInfoBL (MulitDbDal pamMulitDbDal, HttpContext pamHttpContext) {
            dal = pamMulitDbDal;
            http_context = pamHttpContext;
        }

        public async Task<bool> LoginOrCreate (UserBase pamUserBase) {
            if (pamUserBase.name == null || pamUserBase.password == null) {
                return false;
            }

            var user_detial = dal.UserBases.FirstOrDefaultAsync (u => u.name == pamUserBase.name && u.password == pamUserBase.password);
            if (user_detial != null) {
                //写入session
                CookieManager.SetSession ("IsLogin", "1");
                //写入永久cookie
                CookieManager.SetCookies ("uname", user_detial.Result.name);
                CookieManager.SetCookies ("password", user_detial.Result.password);
                return true;
            } else {
                if (ValidationUserDetial (pamUserBase)) {
                    dal.Add (pamUserBase);
                    await dal.SaveChangesAsync ();
                    return true;
                } else {
                    return false;
                }
            }
        }

        public UserBase TransUserBase (string pamOpenId = null, string pamUName = null, string pamPassword = null) {
            UserBase user_base;
            if (string.IsNullOrEmpty (pamOpenId)) {
                //其他浏览器，有用户名密码
                if (string.IsNullOrEmpty (pamUName) || string.IsNullOrEmpty (pamPassword)) return null;
                user_base = new UserBase ();
                user_base.name = pamUName;
                user_base.password = pamPassword;
                return user_base;
            } else {
                user_base = new UserBase ();
                user_base.openid = pamOpenId;
                return user_base;
            }
        }

        public async Task<UserBase> GetUserBase (string pamOpenId = null, string pamName = null, string pamPassword = null) {
            Console.WriteLine ("GetUserDetial..........");
            UserBase user_base = TransUserBase (pamOpenId, pamName, pamPassword);
            //根据cookie检测数据库
            if (user_base.openid != null) {
                //以下是原始sql执行，缺点是紧耦合
                //var ui = dal.UserBases.FromSql ("SELECT id FROM UserDetials", new MySqlParameter ("@OpenId ", pamOpenId)).FirstOrDefaultAsync ().Result;
                var ui = await dal.UserBases.FirstOrDefaultAsync (u => u.openid == user_base.openid);
                //var ui = await dal.UserDetials.Include (u => u.mycompany).FirstOrDefaultAsync (u => u.openid == user_detial.openid);
                user_base = ui;
            } else {
                /*
                //以下是原始sql执行，缺点是紧耦合
                MySqlParameter[] paras = new MySqlParameter[] {
                    new MySqlParameter ("@uname", pamUName),
                    new MySqlParameter ("@password", pamPassword)
                };
                var ui = dal.UserDetials.FromSql ("SELECT * FROM UserDetials where uname=@uname and password=@password", paras).FirstOrDefaultAsync ().Result;
                */
                var ui = await dal.UserBases.FirstOrDefaultAsync (u => u.name == pamName && u.password == pamPassword);
                //var ui = await dal.UserDetials.Include (u => u.mycompany).FirstOrDefaultAsync (u => u.uname == user_detial.uname && u.password == user_detial.password);
                user_base = ui;
            }
            if (user_base != null) {
                //写入session
                return user_base;
            } else {
                return null;
            }
        }

        //检测用户名等是否合法
        public bool ValidationUserDetial (UserBase pamUserBase) {
            return true;
        }

        /*
        public async Task<URelationship> GetUserRelationship (int pamUserId) {
            //var product_type_list = dal.ProductTypes.Where (c => c.id == tmpId).ToListAsync ();
            //var product_category_list = dal.ProductCategorys.ToListAsync ();
            //var user_follow_prod_category = dal.UserFollowProdCategorys.Where (c => c.id == pamId).ToListAsync ();
            //var ui = await dal.UserDetials.Include (u => u.mycompany).FirstOrDefaultAsync (u => u.openid == user_detial.openid);
            var user_relationship = await dal.URelationships.Where (u => u.id == pamUserId).Include (c => c.uFolwProdCategorys).Include (c => c.uFolwArtCategorys).FirstOrDefaultAsync ();
            return user_relationship;
        }
        */

        public async Task<List<Product>> GetFocusProducts (int pamUserId) {
            /*
            var top3 = (from p in dal.Products 
            from c in dal.UFolwProdCategorys 
            where (p.prodCategoryId == c.prodCategoryId && c.userBaseId == pamUserId) 
            select p).Take (6);
            */
            var top3 = from p in dal.Products
            where (from o in dal.UFolwProdCategorys where (o.userBaseId == pamUserId) select o.prodCategoryId).Contains (c.prodCategoryId)
            select p;

            return await top3.ToListAsync ();
        }

        public async Task<List<ArtCategory>> GetFocusArtCategorys (int pamUserId) {
            var top = from c1 in dal.ArtCategorys
            from c2 in dal.UFolwArtCategorys
            where (c1.id == c2.ArtCategoryId && c2.userBaseId == pamUserId)
            select c1;

            return await top.ToListAsync ();
        }

        public async Task<List<Article>> GetArticles (int pamArtCategoryId) {
            var top = from c in dal.Articles
            where (c.artCategoryId == pamArtCategoryId)
            select c;

            return await top.ToListAsync ();
        }

        /*
        public async Task<List<Product>> GetFocusProducts (int pamUserId) {
            var x = this.GetNewFocusProducts (2);
            List<Product> user_follow_prod_Top3 = new List<Product> ();
            var user_follow_prod_categorys = this.GetUFolwProdCategorys (pamUserId);
            foreach (UFolwProdCategory item in user_follow_prod_categorys.Result) {
                var top3 = await dal.Products.Where (p => p.prodCategoryId == item.prodCategoryId).Take (3).ToListAsync ();
                user_follow_prod_Top3.AddRange (top3);
            }

            return user_follow_prod_Top3;
        }

        public async Task<List<UFolwProdCategory>> GetUFolwProdCategorys (int pamUserId) {
            //var user_follow_prod_category = await dal.UFolwProdCategorys.Where (p => user_relationship.UserFollowArtCategorys.Contains (p)).Include (art => art.UserFollowArtCategorys).ToListAsync ();
            var user_follow_prod_category = await dal.UFolwProdCategorys.Where (p => p.userBaseId == pamUserId).ToListAsync ();
            return user_follow_prod_category;
        }
        */
        /*
        public async Task<List<ArtCategory>> GetFocusArtCategorys (int pamUserId) {
            List<ArtCategory> user_follow_art_list = new List<ArtCategory> ();
            var user_follow_art_categorys = this.GetUFolwArtCategorys (pamUserId);
            foreach (UFolwArtCategory item in user_follow_art_categorys.Result) {
                var art_category = await dal.ArtCategorys.Where (p => p.id == item.ArtCategoryId).ToListAsync ();
                user_follow_art_list.AddRange (art_category);
            }

            return user_follow_art_list;
        }

        public async Task<List<UFolwArtCategory>> GetUFolwArtCategorys (int pamUserId) {
            var user_follow_art_categorys = await dal.UFolwArtCategorys.Where (c => c.userBaseId == pamUserId).ToListAsync ();
            return user_follow_art_categorys;
        }
        */
    }
}