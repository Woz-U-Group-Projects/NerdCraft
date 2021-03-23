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
    [Route("api/ShoppingCart")]
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        // GET: ShoppingCart
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.shoppingcarts.Include(s => s.Customer).Include(s => s.Item);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ShoppingCart/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingcart = await _context.shoppingcarts
                .Include(s => s.Customer)
                .Include(s => s.Item)
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (shoppingcart == null)
            {
                return NotFound();
            }

            return View(shoppingcart);
        }

        // GET: ShoppingCart/Create
        [HttpPost]
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.customers, "CustomerID", "Userpass");
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category");
            return View();
        }

        // POST: ShoppingCart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,ItemID,Quantity")] shoppingcart shoppingcart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shoppingcart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.customers, "CustomerID", "Userpass", shoppingcart.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", shoppingcart.ItemID);
            return View(shoppingcart);
        }

        // GET: ShoppingCart/Edit/5
        [HttpPut]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingcart = await _context.shoppingcarts.FindAsync(id);
            if (shoppingcart == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.customers, "CustomerID", "Userpass", shoppingcart.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", shoppingcart.ItemID);
            return View(shoppingcart);
        }

        // POST: ShoppingCart/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerID,ItemID,Quantity")] shoppingcart shoppingcart)
        {
            if (id != shoppingcart.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shoppingcart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!shoppingcartExists(shoppingcart.CustomerID))
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
            ViewData["CustomerID"] = new SelectList(_context.customers, "CustomerID", "Userpass", shoppingcart.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", shoppingcart.ItemID);
            return View(shoppingcart);
        }

        // GET: ShoppingCart/Delete/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingcart = await _context.shoppingcarts
                .Include(s => s.Customer)
                .Include(s => s.Item)
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (shoppingcart == null)
            {
                return NotFound();
            }

            return View(shoppingcart);
        }

        // POST: ShoppingCart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoppingcart = await _context.shoppingcarts.FindAsync(id);
            _context.shoppingcarts.Remove(shoppingcart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool shoppingcartExists(int id)
        {
            return _context.shoppingcarts.Any(e => e.CustomerID == id);
        }
    }
}
