using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.Controllers_ {
    public class Test : Controller {
        private readonly MulitDbDal dal;

        public Test (MulitDbDal pamMulitDbDal) {
            dal = pamMulitDbDal;
        }

        // GET: Test
        public async Task<IActionResult> Index () {
            return View (await dal.Products.ToListAsync ());
        }

        // GET: Test/Details/5
        public async Task<IActionResult> Details (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product = await dal.Products
                .FirstOrDefaultAsync (m => m.id == id);
            if (product == null) {
                return NotFound ();
            }

            return View (product);
        }

        // GET: Test/Create
        public IActionResult Create () {
            return View ();
        }

        // POST: Test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("id,pname,description,price,discount,image_url")] Product product) {
            if (ModelState.IsValid) {
                dal.Add (product);
                await dal.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }
            return View (product);
        }

        // GET: Test/Edit/5
        public async Task<IActionResult> Edit (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product = await dal.Products.FindAsync (id);
            if (product == null) {
                return NotFound ();
            }
            return View (product);
        }

        // POST: Test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind ("id,pname,description,price,discount,image_url")] Product product) {
            if (id != product.id) {
                return NotFound ();
            }

            if (ModelState.IsValid) {
                try {
                    dal.Update (product);
                    await dal.SaveChangesAsync ();
                } catch (DbUpdateConcurrencyException) {
                    if (!ProductExists (product.id)) {
                        return NotFound ();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction (nameof (Index));
            }
            return View (product);
        }

        // GET: Test/Delete/5
        public async Task<IActionResult> Delete (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product = await dal.Products
                .FirstOrDefaultAsync (m => m.id == id);
            if (product == null) {
                return NotFound ();
            }

            return View (product);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (int id) {
            var product = await dal.Products.FindAsync (id);
            dal.Products.Remove (product);
            await dal.SaveChangesAsync ();
            return RedirectToAction (nameof (Index));
        }

        private bool ProductExists (int id) {
            return dal.Products.Any (e => e.id == id);
        }
    }
}