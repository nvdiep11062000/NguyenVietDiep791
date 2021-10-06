using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVietDiep791.Data;

namespace NguyenVietDiep791.Models
{
    public class NVD0791Controller : Controller
    {
        private readonly NguyenVietDiep791Context _context;

        public NVD0791Controller(NguyenVietDiep791Context context)
        {
            _context = context;
        }

        // GET: NVD0791
        public async Task<IActionResult> Index()
        {
            return View(await _context.NVD0791.ToListAsync());
        }

        // GET: NVD0791/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVD0791 = await _context.NVD0791
                .FirstOrDefaultAsync(m => m.NVDId == id);
            if (nVD0791 == null)
            {
                return NotFound();
            }

            return View(nVD0791);
        }

        // GET: NVD0791/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NVD0791/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NVDId,NVDName,NVDGender")] NVD0791 nVD0791)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nVD0791);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nVD0791);
        }

        // GET: NVD0791/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVD0791 = await _context.NVD0791.FindAsync(id);
            if (nVD0791 == null)
            {
                return NotFound();
            }
            return View(nVD0791);
        }

        // POST: NVD0791/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NVDId,NVDName,NVDGender")] NVD0791 nVD0791)
        {
            if (id != nVD0791.NVDId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nVD0791);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVD0791Exists(nVD0791.NVDId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nVD0791);
        }

        // GET: NVD0791/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVD0791 = await _context.NVD0791
                .FirstOrDefaultAsync(m => m.NVDId == id);
            if (nVD0791 == null)
            {
                return NotFound();
            }

            return View(nVD0791);
        }

        // POST: NVD0791/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nVD0791 = await _context.NVD0791.FindAsync(id);
            _context.NVD0791.Remove(nVD0791);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NVD0791Exists(string id)
        {
            return _context.NVD0791.Any(e => e.NVDId == id);
        }
    }
}
