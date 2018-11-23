using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEditor.DataAccessLayer;
using WebEditor.Models;
using WebEditor.ViewModels;

namespace WebEditor.ViewComponents {
    public class ProductList : ViewComponent {
        private readonly MulitDbDal dal;
        public ProductList (MulitDbDal parmMulitDbDal) {
            dal = parmMulitDbDal;
        }

        public async Task<IViewComponentResult> InvokeAsync (int tid) {
            List<Product> product_list = await GetProducts (tid);
            return View ("Index", product_list);
            /*
            List<ProductVM> pvm_list = new List<ProductVM> ();
            foreach (Product item in product_list) {
                ProductVM pvm = new ProductVM ();
                pvm.product = item;
                pvm_list.Add (pvm);
            }
            return View ("Index", pvm_list);
            */
        }

        private Task<List<Product>> GetProducts (int tmpTid) {
            var product_list = dal.Products.Where (p => p.id == tmpTid).ToListAsync ();
            return product_list;
        }
    }
}