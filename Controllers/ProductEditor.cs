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
    public class ProductEditor : Controller {
        /*
        private readonly Dal _context;

        public ProductEditor (Dal context) {
            _context = context;
        }

        // GET: A
        public async Task<IActionResult> Index () {
            return View (await _context.Products.ToListAsync ());
        }

        // GET: A/Details/5
        public async Task<IActionResult> Details (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync (m => m.id == id);
            if (product == null) {
                return NotFound ();
            }

            return View (product);
        }

        // GET: A/Create
        public IActionResult Create () {
            return View ();
        }

        // POST: A/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind ("id,tid,pname,description,price,discount,image_url")] Product product) {
            if (ModelState.IsValid) {
                _context.Add (product);
                await _context.SaveChangesAsync ();
                return RedirectToAction (nameof (Index));
            }
            return View (product);
        }

        // GET: A/Edit/5
        public async Task<IActionResult> Edit (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product = await _context.Products.FindAsync (id);
            if (product == null) {
                return NotFound ();
            }
            return View (product);
        }

        // POST: A/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, [Bind ("id,tid,pname,description,price,discount,image_url")] Product product) {
            if (id != product.id) {
                return NotFound ();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update (product);
                    await _context.SaveChangesAsync ();
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

        // GET: A/Delete/5
        public async Task<IActionResult> Delete (int? id) {
            if (id == null) {
                return NotFound ();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync (m => m.id == id);
            if (product == null) {
                return NotFound ();
            }

            return View (product);
        }

        // POST: A/Delete/5
        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (int id) {
            var product = await _context.Products.FindAsync (id);
            _context.Products.Remove (product);
            await _context.SaveChangesAsync ();
            return RedirectToAction (nameof (Index));
        }

        private bool ProductExists (int id) {
            return _context.Products.Any (e => e.id == id);
        }
        */
    }
}