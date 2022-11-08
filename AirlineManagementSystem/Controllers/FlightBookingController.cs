using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirlineManagementSystem.Models;

namespace AirlineManagementSystem.Controllers
{
    public class FlightBookingController : Controller
    {
        private readonly AppDbContext _context;

        public FlightBookingController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FlightBooking
        public async Task<IActionResult> Index()
        {
            return View(await _context.FlightBookingModels.ToListAsync());
        }

        // GET: FlightBooking/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightBookingModel = await _context.FlightBookingModels
                .FirstOrDefaultAsync(m => m.Bid == id);
            if (flightBookingModel == null)
            {
                return NotFound();
            }

            return View(flightBookingModel);
        }

        // GET: FlightBooking/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlightBooking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bid,bCusName,bCusAddress,bCusEmail,bCusSeats,bCusPhoneNum,bCusCnic,ResId")] FlightBookingModel flightBookingModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flightBookingModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightBookingModel);
        }

        // GET: FlightBooking/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightBookingModel = await _context.FlightBookingModels.FindAsync(id);
            if (flightBookingModel == null)
            {
                return NotFound();
            }
            return View(flightBookingModel);
        }

        // POST: FlightBooking/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bid,bCusName,bCusAddress,bCusEmail,bCusSeats,bCusPhoneNum,bCusCnic,ResId")] FlightBookingModel flightBookingModel)
        {
            if (id != flightBookingModel.Bid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightBookingModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightBookingModelExists(flightBookingModel.Bid))
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
            return View(flightBookingModel);
        }

        // GET: FlightBooking/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightBookingModel = await _context.FlightBookingModels
                .FirstOrDefaultAsync(m => m.Bid == id);
            if (flightBookingModel == null)
            {
                return NotFound();
            }

            return View(flightBookingModel);
        }

        // POST: FlightBooking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flightBookingModel = await _context.FlightBookingModels.FindAsync(id);
            _context.FlightBookingModels.Remove(flightBookingModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightBookingModelExists(int id)
        {
            return _context.FlightBookingModels.Any(e => e.Bid == id);
        }
    }
}
