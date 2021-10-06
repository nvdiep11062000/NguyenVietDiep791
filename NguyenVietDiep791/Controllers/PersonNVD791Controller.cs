using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVietDiep791.Data;
using NguyenVietDiep791.Models;

namespace NguyenVietDiep791.Controllers
{
    public class PersonNVD791Controller : Controller
    {
        private readonly NguyenVietDiep791Context _context;

        public PersonNVD791Controller(NguyenVietDiep791Context context)
        {
            _context = context;
        }

        // GET: PersonNVD791
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNVD791.ToListAsync());
        }

        // GET: PersonNVD791/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNVD791 = await _context.PersonNVD791
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNVD791 == null)
            {
                return NotFound();
            }

            return View(personNVD791);
        }

        // GET: PersonNVD791/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNVD791/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonNVD791 personNVD791)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNVD791);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNVD791);
        }

        // GET: PersonNVD791/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNVD791 = await _context.PersonNVD791.FindAsync(id);
            if (personNVD791 == null)
            {
                return NotFound();
            }
            return View(personNVD791);
        }

        // POST: PersonNVD791/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonNVD791 personNVD791)
        {
            if (id != personNVD791.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNVD791);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNVD791Exists(personNVD791.PersonId))
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
            return View(personNVD791);
        }

        // GET: PersonNVD791/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNVD791 = await _context.PersonNVD791
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNVD791 == null)
            {
                return NotFound();
            }

            return View(personNVD791);
        }

        // POST: PersonNVD791/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personNVD791 = await _context.PersonNVD791.FindAsync(id);
            _context.PersonNVD791.Remove(personNVD791);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNVD791Exists(string id)
        {
            return _context.PersonNVD791.Any(e => e.PersonId == id);
        }
    }
}
