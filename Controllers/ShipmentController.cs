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
    [Route("api/Shipment")]
    public class ShipmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShipmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        // GET: Shipment
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.shipments.Include(s => s.Order);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Shipment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipment = await _context.shipments
                .Include(s => s.Order)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (shipment == null)
            {
                return NotFound();
            }

            return View(shipment);
        }

        // GET: Shipment/Create
        [HttpPost]
        public IActionResult Create()
        {
            ViewData["OrderID"] = new SelectList(_context.orders, "OrderNum", "OrderEmail");
            return View();
        }

        // POST: Shipment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,Address1,Address2,City,StateProvince,Country,PostalID,Fee,Company,ShipName")] shipment shipment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderID"] = new SelectList(_context.orders, "OrderNum", "OrderEmail", shipment.OrderID);
            return View(shipment);
        }

        // GET: Shipment/Edit/5
        [HttpPut]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipment = await _context.shipments.FindAsync(id);
            if (shipment == null)
            {
                return NotFound();
            }
            ViewData["OrderID"] = new SelectList(_context.orders, "OrderNum", "OrderEmail", shipment.OrderID);
            return View(shipment);
        }

        // POST: Shipment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,Address1,Address2,City,StateProvince,Country,PostalID,Fee,Company,ShipName")] shipment shipment)
        {
            if (id != shipment.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!shipmentExists(shipment.OrderID))
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
            ViewData["OrderID"] = new SelectList(_context.orders, "OrderNum", "OrderEmail", shipment.OrderID);
            return View(shipment);
        }

        // GET: Shipment/Delete/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipment = await _context.shipments
                .Include(s => s.Order)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (shipment == null)
            {
                return NotFound();
            }

            return View(shipment);
        }

        // POST: Shipment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shipment = await _context.shipments.FindAsync(id);
            _context.shipments.Remove(shipment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool shipmentExists(int id)
        {
            return _context.shipments.Any(e => e.OrderID == id);
        }
    }
}
