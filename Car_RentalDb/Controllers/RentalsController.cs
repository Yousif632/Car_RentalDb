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
    public class RentalsController : Controller
    {
        private readonly Car_RentalDbContext _context;

        public RentalsController(Car_RentalDbContext context)
        {
            _context = context;
        }

        // GET: Rentals
        public async Task<IActionResult> Index(int? searchBookingRate)
        {
            IQueryable<Rental> rentals = _context.Rental;

            ViewData["BookingRate"] = searchBookingRate;
           

            if (searchBookingRate.HasValue)
            {
                rentals = rentals.Where(r => r.BookingRate == searchBookingRate.Value);
            }

            return View(await rentals.ToListAsync());
        }
        // GET: Rentals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental
                .Include(r => r.Car)
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(m => m.RentalID == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        // GET: Rentals/Create
        public IActionResult Create()
        {
            ViewData["CarID"] = new SelectList(_context.Car, "CarID", "FuelType");
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerId", "Address");
            return View();
        }

        // POST: Rentals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalID,CarID,CustomerID,StartDate,EndDate,BookingRate,InsuranceCharge,FuelCharge")] Rental rental)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(rental);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarID"] = new SelectList(_context.Car, "CarID", "FuelType", rental.CarID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerId", "Address", rental.CustomerID);
            return View(rental);
        }

        // GET: Rentals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental.FindAsync(id);
            if (rental == null)
            {
                return NotFound();
            }
            ViewData["CarID"] = new SelectList(_context.Car, "CarID", "FuelType", rental.CarID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerId", "Address", rental.CustomerID);
            return View(rental);
        }

        // POST: Rentals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalID,CarID,CustomerID,StartDate,EndDate,BookingRate,InsuranceCharge,FuelCharge")] Rental rental)
        {
            if (id != rental.RentalID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(rental);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalExists(rental.RentalID))
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
            ViewData["CarID"] = new SelectList(_context.Car, "CarID", "FuelType", rental.CarID);
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerId", "Address", rental.CustomerID);
            return View(rental);
        }

        // GET: Rentals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rental
                .Include(r => r.Car)
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(m => m.RentalID == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        // POST: Rentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rental = await _context.Rental.FindAsync(id);
            if (rental != null)
            {
                _context.Rental.Remove(rental);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalExists(int id)
        {
            return _context.Rental.Any(e => e.RentalID == id);
        }
    }
}
