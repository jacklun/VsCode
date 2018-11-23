using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.ViewComponents {
    public class UserAttentionProductCategoryList : ViewComponent {
        private readonly Dal dal;

        public UserAttentionProductCategoryList (Dal tmpDal) {
            dal = tmpDal;
        }

        public async Task<IViewComponentResult> InvokeAsync () {
            List<ProductCategory> items = await GetUserAttentionProductCategory ();
            return View ("Index", items);
        }

        private Task<List<ProductCategory>> GetUserAttentionProductCategory () {
            //var product_type_list = dal.ProductTypes.Where (c => c.id == tmpId).ToListAsync ();
            //var product_category_list = dal.ProductCategorys.ToListAsync ();
            //var user_attention_product_category = dal.UserAttentionProductCategorys.Where (c => c.id == tmpId).ToListAsync ();
            return null;
            //user_attention_product_category;
        }
    }
}