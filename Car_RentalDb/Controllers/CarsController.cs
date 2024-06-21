using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_RentalDb.Areas.Identity.Data;
using Car_RentalDb.Models;

namespace Car_RentalDb.Controllers
{
    public class CarsController : Controller
    {
        private readonly Car_RentalDbContext _context;

        public CarsController(Car_RentalDbContext context)
        {
            _context = context;
        }

        // GET: Cars
        // Added search filter for the model//
        public async Task<IActionResult> Index(string sortOrder, string searchString )
        {
            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;
            ViewData["ModelSortParm"] = String.IsNullOrEmpty(sortOrder) ? "model_desc" : "";
            ViewData["YearSortParm"] = sortOrder == "Year" ? "Year_desc" : "Year";
            var cars = from c in _context.Car
                       select c; 
            IQueryable < Car > Cars = _context.Car;

            if (!string.IsNullOrEmpty(searchString))
            {
                Cars = Cars.Where(s => s.Model.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "model_desc":
                    cars = cars.OrderByDescending(s => s.Model);
                    break;
                case "Year":
                    cars = cars.OrderBy(s => s.Year);
                    break;
                case "Year_desc":
                    cars = cars.OrderByDescending(s => s.Year);
                    break;
                default:
                    cars = cars.OrderBy(s => s.Model);
                    break;
            }
            
            return View(await Cars.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .Include(c => c.Location)
                .Include(c => c.Staff)
                .FirstOrDefaultAsync(m => m.CarID == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            ViewData["LocationID"] = new SelectList(_context.Set<Location>(), "LocationID", "LocationID");
            ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId");
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarID,StaffID,LocationID,Model,Year,DailyRate,FuelType,IsAvailable")] Car car)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationID"] = new SelectList(_context.Set<Location>(), "LocationID", "LocationID", car.LocationID);
            ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId", car.StaffID);
            return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            ViewData["LocationID"] = new SelectList(_context.Set<Location>(), "LocationID", "LocationID", car.LocationID);
            ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId", car.StaffID);
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CarID,StaffID,LocationID,Model,Year,DailyRate,FuelType,IsAvailable")] Car car)
        {
            if (id != car.CarID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.CarID))
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
            ViewData["LocationID"] = new SelectList(_context.Set<Location>(), "LocationID", "LocationID", car.LocationID);
            ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId", car.StaffID);
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .Include(c => c.Location)
                .Include(c => c.Staff)
                .FirstOrDefaultAsync(m => m.CarID == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Car.FindAsync(id);
            if (car != null)
            {
                _context.Car.Remove(car);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Car.Any(e => e.CarID == id);
        }
    }
}
