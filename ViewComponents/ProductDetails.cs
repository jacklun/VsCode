using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEditor.Models;
using WebEditor.ViewModels;

namespace WebEditor.ViewComponents {
    public class ProductDetails : ViewComponent {
        /*
        //private readonly DbContext dbcontext;
        public async Task<IViewComponentResult> InvokeAsync (int pid) {
            Product p = await GetProduct (pid);
            ProductVM pvm = new ProductVM ();
            pvm.product = p;
            return View ("Index", pvm);
        }

        private Task<Product> GetProduct (int tmpPid) {
            //DataAccessLayer.Dal dal = new DataAccessLayer.Dal ();
            //var product = dal.Products.Where (c => c.id == tmpPid).FirstOrDefault ();
            //return Task.FromResult (product);
            return null;
        }
        */
    }
}