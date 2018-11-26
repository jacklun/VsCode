using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebEditor.BusinessLayer;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.Controllers_ {
    public class UserInfoEditor : Controller {
        /*
        private readonly Dal _context;

        public UserInfoEditor (Dal context) {
            _context = context;
        }

        // GET: UserInfoEditor
        public async Task<IActionResult> Index () {
            UserInfoBL ulbl = new UserInfoBL (_context);

            //先检测是否已登录
            UserBase user_base = null;
            //微信浏览器，则用openid检测数据库中的用户
            bool is_wxbrowser = Request.Headers["User-Agent"].ToString ().ToLower ().IndexOf ("micromessenger") != -1;
            if (is_wxbrowser) {
                string openid = "dddddddd";
                user_base = await ulbl.GetUserBase (pamOpenId: openid);
            } else {
                //其他浏览器则从cookie中检测用户名和密码
                CookieManager.http_context = HttpContext;
                //测试用，删除cookie保存的用户名密码
                //CookieManager.DeleteCookies ("uname");
                //CookieManager.DeleteCookies ("password");

                string uname = CookieManager.GetCookies ("uname");
                string password = CookieManager.GetCookies ("password");

                if (!string.IsNullOrEmpty (uname) && !string.IsNullOrEmpty (password)) {
                    user_base = await ulbl.GetUserBase (pamUName: uname, pamPassword: password);
                    //ViewBag["UserInfo"] = userinfo;
                }
            }

            if (user_base != null) {
                return View (nameof (Index), user_base);
            } else {
                return RedirectToAction ("Index", "UserLogin");
            }
            //return View (await _context.UserInfos.ToListAsync ());
        }

        // GET: UserInfoEditor/Details/5
        public async Task<IActionResult> Details (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var user_base = await _context.UserBases
                .FirstOrDefaultAsync (u => u.id == id);
            if (user_base == null) {
                return NotFound ();
            }

            return View (user_base);
        }

        // GET: UserInfoEditor/Create
        public IActionResult Create () {
            return View ();
        }

        // POST: UserInfoEditor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("id,uname,password")] UserBase pamUserBase) {
            if (ModelState.IsValid) {
                _context.Add (pamUserBase);
                await _context.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }
            return View (pamUserBase);
        }

        // GET: UserInfoEditor/Edit/5
        public async Task<IActionResult> Edit (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var user_base = await _context.UserBases.FindAsync (id);
            if (user_base == null) {
                return NotFound ();
            }
            return View (user_base);
        }

        // POST: UserInfoEditor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind ("id,uname,password")] UserBase pamUserBase) {
            if (id != pamUserBase.id) {
                return NotFound ();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update (pamUserBase);
                    await _context.SaveChangesAsync ();
                } catch (DbUpdateConcurrencyException) {
                    if (!UserBasesExists (pamUserBase.id)) {
                        return NotFound ();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction (nameof (Index));
            }
            return View (pamUserBase);
        }

        // GET: UserInfoEditor/Delete/5
        public async Task<IActionResult> Delete (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var user_base = await _context.UserBases
                .FirstOrDefaultAsync (m => m.id == id);
            if (user_base == null) {
                return NotFound ();
            }

            return View (user_base);
        }

        // POST: UserInfoEditor/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (int id) {
            var user_base = await _context.UserBases.FindAsync (id);
            _context.UserBases.Remove (user_base);
            await _context.SaveChangesAsync ();
            return RedirectToAction (nameof (Index));
        }

        private bool UserBasesExists (int id) {
            return _context.UserBases.Any (e => e.id == id);
        }
        */
    }
}