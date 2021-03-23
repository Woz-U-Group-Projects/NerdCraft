using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NerdCraft.Models;

namespace NerdCraft.Controllers
{
    [Route("api/Returnment")]
    public class ReturnmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReturnmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        // GET: Returnment
        public async Task<IActionResult> Index()
        {
            return View(await _context.returnments.ToListAsync());
        }

        // GET: Returnment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returnment = await _context.returnments
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (returnment == null)
            {
                return NotFound();
            }

            return View(returnment);
        }

        // GET: Returnment/Create
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Returnment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,ItemID,Quantity,Comments,Approval")] returnment returnment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(returnment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(returnment);
        }

        // GET: Returnment/Edit/5
        [HttpPut]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returnment = await _context.returnments.FindAsync(id);
            if (returnment == null)
            {
                return NotFound();
            }
            return View(returnment);
        }

        // POST: Returnment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,ItemID,Quantity,Comments,Approval")] returnment returnment)
        {
            if (id != returnment.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(returnment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!returnmentExists(returnment.OrderID))
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
            return View(returnment);
        }

        // GET: Returnment/Delete/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returnment = await _context.returnments
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (returnment == null)
            {
                return NotFound();
            }

            return View(returnment);
        }

        // POST: Returnment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var returnment = await _context.returnments.FindAsync(id);
            _context.returnments.Remove(returnment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool returnmentExists(int id)
        {
            return _context.returnments.Any(e => e.OrderID == id);
        }
    }
}
