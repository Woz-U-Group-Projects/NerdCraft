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
    [Route("api/WishList")]
    public class WishListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WishListController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        // GET: WishList
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.wishlists.Include(w => w.Customer).Include(w => w.Item);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: WishList/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlist = await _context.wishlists
                .Include(w => w.Customer)
                .Include(w => w.Item)
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (wishlist == null)
            {
                return NotFound();
            }

            return View(wishlist);
        }

        // GET: WishList/Create
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.customers, "CustomerID", "Userpass");
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category");
            return View();
        }

        // POST: WishList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,ItemID")] wishlist wishlist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wishlist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.customers, "CustomerID", "Userpass", wishlist.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", wishlist.ItemID);
            return View(wishlist);
        }

        // GET: WishList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlist = await _context.wishlists.FindAsync(id);
            if (wishlist == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.customers, "CustomerID", "Userpass", wishlist.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", wishlist.ItemID);
            return View(wishlist);
        }

        // POST: WishList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerID,ItemID")] wishlist wishlist)
        {
            if (id != wishlist.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wishlist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!wishlistExists(wishlist.CustomerID))
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
            ViewData["CustomerID"] = new SelectList(_context.customers, "CustomerID", "Userpass", wishlist.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.items, "ItemID", "Category", wishlist.ItemID);
            return View(wishlist);
        }

        // GET: WishList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishlist = await _context.wishlists
                .Include(w => w.Customer)
                .Include(w => w.Item)
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (wishlist == null)
            {
                return NotFound();
            }

            return View(wishlist);
        }

        // POST: WishList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wishlist = await _context.wishlists.FindAsync(id);
            _context.wishlists.Remove(wishlist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool wishlistExists(int id)
        {
            return _context.wishlists.Any(e => e.CustomerID == id);
        }
    }
}
