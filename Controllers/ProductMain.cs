using Microsoft.AspNetCore.Mvc;
using WebEditor.DataAccessLayer;

namespace WebEditor.Controllers {
    public class ProductMain : Controller {

        private readonly MulitDbDal dal;

        public ProductMain (MulitDbDal pamMulitDbDal) {
            dal = pamMulitDbDal;
        }

        public IActionResult Index () {
            return View ("Index");
            //return View();
        }

        public IActionResult ProductList (string id) {
            //int tid;
            bool s = int.TryParse (id, out int tid0);
            if (s)
                ViewData["tid"] = tid0;
            else
                ViewData["tid"] = 1;
            return View ("ProductList");
        }

        public IActionResult ProductDetails (string id) {
            //int tid;
            bool s = int.TryParse (id, out int pid);
            if (s)
                ViewData["pid"] = pid;
            else
                ViewData["pid"] = 1;
            return View ("ProductDetails");
        }
    }
}