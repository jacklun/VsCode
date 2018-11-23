using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.Controllers {
    public class HomeController : Controller {
        private readonly Dal dal;

        public HomeController (Dal parmDal) {
            dal = parmDal;
        }

        public async Task<IActionResult> Index () {
            return View (await dal.Products.ToListAsync ());
        }

        public IActionResult About () {
            ViewData["Message"] = "Your application description page.111111111111";

            return View ();
        }

        public IActionResult Contact () {
            ViewData["Message"] = "Your contact page.";

            return View ();
        }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}