using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebEditor.BusinessLayer;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.Controllers {
    public class HomeController : Controller {

        private readonly MulitDbDal dal;

        public HomeController (MulitDbDal pamMulitDbDal) {
            dal = pamMulitDbDal;
            
            //_Logger = logger;
        }

        public async Task<IActionResult> Index () {
            UserInfoBL ubl = new UserInfoBL (dal, HttpContext);
            ViewBag.UserSessionId = HttpContext.Session.Id;
            ViewBag.UserId = 2;

            return View (ubl);
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