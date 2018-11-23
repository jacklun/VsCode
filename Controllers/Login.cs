using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebEditor.BusinessLayer;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.Controllers_ {
    public class Login : Controller {
        private readonly Dal _context;

        public Login (Dal context) {
            _context = context;
        }

        // GET: UserLogin
        public IActionResult Index () {
            //检测cookie，若有，直接登录
            // 没有则显示登录或注册View
            return View ();
        }

        public IActionResult SkipToUserInfoEditor () {
            //检测cookie，若有，直接登录
            // 没有则显示登录或注册View
            return View ("SkipToUserInfoEditor");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginOrCreateSkipToUserInfoEditor ([Bind ("uname,password")] UserBase parmUserBase) {
            UserInfoBL ulbl = new UserInfoBL (_context);
            bool isvalid = await ulbl.LoginOrCreate (parmUserBase);
            if (isvalid) {
                return RedirectToAction ("Index", "UserInfoEditor");
            } else {
                return View ("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginOrCreate ([Bind ("uname,password")] UserBase parmUserBase) {
            UserInfoBL ulbl = new UserInfoBL (_context);
            CookieManager.http_context = HttpContext;

            //测试用，删除cookie保存的用户名密码
            CookieManager.DeleteCookies ("uname");
            CookieManager.DeleteCookies ("password");

            bool isvalid = await ulbl.LoginOrCreate (parmUserBase);
            if (isvalid) {
                return RedirectToAction ("Index", "ProductMain");
            } else {
                return View ("Error");
            }
        }
    }
}