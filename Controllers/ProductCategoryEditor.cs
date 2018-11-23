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
    public class ProductCategoryEditor : Controller {
        /*
        private readonly Dal _context;

        public ProductCategoryEditor (Dal context) {
            _context = context;
        }

        // GET: ProductTypeEditor
        public async Task<IActionResult> Index () {
            return View (await _context.ProductCategorys.ToListAsync ());
        }

        // GET: ProductTypeEditor/Details/5
        public async Task<IActionResult> Details (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product_category = await _context.ProductCategorys
                .FirstOrDefaultAsync (m => m.id == id);
            if (product_category == null) {
                return NotFound ();
            }

            return View (product_category);
        }

        // GET: ProductTypeEditor/Create
        public IActionResult Create () {
            return View ();
        }

        // POST: ProductTypeEditor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("id,tname")] ProductCategory parmProductCategory) {
            if (ModelState.IsValid) {
                _context.Add (parmProductCategory);
                await _context.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }
            return View (parmProductCategory);
        }

        // GET: ProductTypeEditor/Edit/5
        public async Task<IActionResult> Edit (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product_category = await _context.ProductCategorys.FindAsync (id);
            if (product_category == null) {
                return NotFound ();
            }
            return View (product_category);
        }

        // POST: ProductTypeEditor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind ("id,tname")] ProductCategory parmProductCategory) {
            if (id != parmProductCategory.id) {
                return NotFound ();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update (parmProductCategory);
                    await _context.SaveChangesAsync ();
                } catch (DbUpdateConcurrencyException) {
                    if (!ProductCategoryExists (parmProductCategory.id)) {
                        return NotFound ();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction (nameof (Index));
            }
            return View (parmProductCategory);
        }

        // GET: ProductTypeEditor/Delete/5
        public async Task<IActionResult> Delete (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product_category = await _context.ProductCategorys
                .FirstOrDefaultAsync (m => m.id == id);
            if (product_category == null) {
                return NotFound ();
            }

            return View (product_category);
        }

        // POST: ProductTypeEditor/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (int id) {
            var product_category = await _context.ProductCategorys.FindAsync (id);
            _context.ProductCategorys.Remove (product_category);
            await _context.SaveChangesAsync ();
            return RedirectToAction (nameof (Index));
        }

        private bool ProductCategoryExists (int id) {
            return _context.ProductCategorys.Any (e => e.id == id);
        }
        */
    }
}