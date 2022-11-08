using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirlineManagementSystem.Models;
using Microsoft.AspNetCore.Http;

namespace AirlineManagementSystem.Controllers
{
    public class FlightDetailController : Controller
    {
        private readonly AppDbContext _context;

        public FlightDetailController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FlightDetailsModels
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                return View(_context.FlightDetailsModels.ToList());
            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            
        }

        // GET: FlightDetailsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var flightDetailsModel = await _context.FlightDetailsModels
                    .FirstOrDefaultAsync(m => m.ResID == id);
                if (flightDetailsModel == null)
                {
                    return NotFound();
                }

                return View(flightDetailsModel);

            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            
        }

        // GET: FlightDetailsModels/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                ViewBag.PlaneList = new SelectList(_context.AeroPlaneModels, "PlaneId", "APlaneName");
                return View();

            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
           
        }

        // POST: FlightDetailsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResID,ResFrom,ResTo,ResDepDate,ResTime,PlaneId,PlaneSeat,ResTicketPrice,ResPlaneType")] FlightDetailsModel flightDetailsModel)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                if (ModelState.IsValid)
                {
                    _context.FlightDetailsModels.Add(flightDetailsModel);
                    _context.SaveChanges();
                    ViewBag.m = "Record Saved";
                    ViewBag.PlaneList = new SelectList(_context.AeroPlaneModels, "PlaneId", "APlaneName", flightDetailsModel.PlaneId);
                    return View();
                }
                ViewBag.PlaneList = new SelectList(_context.AeroPlaneModels, "PlaneId", "APlaneName", flightDetailsModel.PlaneId);
                return View(flightDetailsModel);

            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            
        }

        // GET: FlightDetailsModels/Edit/5
        public ActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                var detail = _context.FlightDetailsModels.Where(model => model.ResID == id).FirstOrDefault();


                ViewBag.PlaneList = new SelectList(_context.AeroPlaneModels, "PlaneId", "APlaneName");
                return View(detail);

            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
           
           
           
        }

        // POST: FlightDetailsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("ResID,ResFrom,ResTo,ResDepDate,ResTime,PlaneId,PlaneSeat,ResTicketPrice,ResPlaneType")] FlightDetailsModel flightDetailsModel)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                try
                {
                    var flightDetail = _context.FlightDetailsModels.Where(model => model.ResID == id).FirstOrDefault();
                    ViewBag.PlaneList = new SelectList(_context.AeroPlaneModels, "PlaneId", "APlaneName");
                    _context.FlightDetailsModels.Remove(flightDetail);
                    flightDetailsModel.PlaneId = flightDetail.PlaneId;
                    _context.FlightDetailsModels.Add(flightDetailsModel);
                    _context.SaveChanges();
                    ViewBag.m = "Information Updated";
                    return View();
                }
                catch
                {
                    ViewBag.PlaneList = new SelectList(_context.AeroPlaneModels, "PlaneId", "APlaneName");
                    return View(flightDetailsModel);
                }

            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            
           
        }

        // GET: FlightDetailsModels/Delete/5
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                var detail = _context.FlightDetailsModels.Where(model => model.ResID == id).FirstOrDefault();
                return View(detail);
            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
           

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                try
                {
                    var flightDetails = _context.FlightDetailsModels.Where(model => model.ResID == id).FirstOrDefault();
                    _context.FlightDetailsModels.Remove(flightDetails);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
           
        }

       
    }
}
