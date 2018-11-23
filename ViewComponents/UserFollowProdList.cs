using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.ViewComponents {
    public class UserFollowProdList : ViewComponent {
        private readonly MulitDbDal dal;

        public UserFollowProdList (MulitDbDal parmMulitDbDal) {
            dal = parmMulitDbDal;
        }

        public async Task<IViewComponentResult> InvokeAsync (int parmUserId) {
            UserRelationship user_relationship = await GetUserRelationship (parmUserId);
            List<Product> product_list = null;
            foreach (UserFollowProdCategory item in user_relationship.UserFollowProdCategorys) {
                //new List<Product> ();
                product_list = await GetFocusProduct (item.id);
            }
            return View ("Index", product_list);
            //return View ("Index");
        }

        private async Task<UserRelationship> GetUserRelationship (int parmUserId) {
            //var product_type_list = dal.ProductTypes.Where (c => c.id == tmpId).ToListAsync ();
            //var product_category_list = dal.ProductCategorys.ToListAsync ();
            //var user_follow_prod_category = dal.UserFollowProdCategorys.Where (c => c.id == parmId).ToListAsync ();
            //var ui = await dal.UserDetials.Include (u => u.mycompany).FirstOrDefaultAsync (u => u.openid == user_detial.openid);
            var user_relationship = await dal.UserRelationships.Where (u => u.id == parmUserId).Include (c => c.UserFollowProdCategorys).Include (c => c.UserFollowArtCategorys).FirstOrDefaultAsync ();
            return user_relationship;
        }

        private async Task<List<Product>> GetFocusProduct (int parmProdCategoryId) {
            var user_follow_prod_Top3 = await dal.Products.Where (p => p.ProdCategoryId == parmProdCategoryId).Take (3).ToListAsync ();
            return user_follow_prod_Top3;
        }
    }
}