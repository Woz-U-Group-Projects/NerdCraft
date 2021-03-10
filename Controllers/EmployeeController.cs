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
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        // GET: Employee
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.employees.Include(e => e.IDNavigation).Include(e => e.SupervisorNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.employees
                .Include(e => e.IDNavigation)
                .Include(e => e.SupervisorNavigation)
                .FirstOrDefaultAsync(m => m.EmployeeEmail == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            ViewData["ID"] = new SelectList(_context.people, "ID", "Email");
            ViewData["Supervisor"] = new SelectList(_context.employees, "EmployeeEmail", "EmployeeEmail");
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,EmployeeEmail,Supervisor,Userpass")] employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ID"] = new SelectList(_context.people, "ID", "Email", employee.ID);
            ViewData["Supervisor"] = new SelectList(_context.employees, "EmployeeEmail", "EmployeeEmail", employee.Supervisor);
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["ID"] = new SelectList(_context.people, "ID", "Email", employee.ID);
            ViewData["Supervisor"] = new SelectList(_context.employees, "EmployeeEmail", "EmployeeEmail", employee.Supervisor);
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,EmployeeEmail,Supervisor,Userpass")] employee employee)
        {
            if (id != employee.EmployeeEmail)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!employeeExists(employee.EmployeeEmail))
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
            ViewData["ID"] = new SelectList(_context.people, "ID", "Email", employee.ID);
            ViewData["Supervisor"] = new SelectList(_context.employees, "EmployeeEmail", "EmployeeEmail", employee.Supervisor);
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.employees
                .Include(e => e.IDNavigation)
                .Include(e => e.SupervisorNavigation)
                .FirstOrDefaultAsync(m => m.EmployeeEmail == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var employee = await _context.employees.FindAsync(id);
            _context.employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool employeeExists(string id)
        {
            return _context.employees.Any(e => e.EmployeeEmail == id);
        }
    }
}
