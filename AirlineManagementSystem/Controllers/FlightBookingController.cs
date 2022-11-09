using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirlineManagementSystem.Models;
using AirlineManagementSystem.Models;
using Microsoft.AspNetCore.Http;


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
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("UserLogin","User");
            }
           
        }

        public ActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                ViewBag.dcity = _context.FlightDetailsModels.Select(l => l.ResFrom).Distinct().ToList();
                ViewBag.acity = _context.FlightDetailsModels.Select(l => l.ResTo).Distinct().ToList();
                return View();
            }
            else
            {
                return RedirectToAction("UserLogin","User");
                
            }

            
        }

        [HttpPost]
        public ActionResult Search(string cityto,string cityfrom, string date1)
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                var details = _context.FlightDetailsModels.Where(l => l.ResTo.Equals(cityto) && l.ResFrom.Equals(cityfrom) && l.ResDepDate.Equals(date1)).FirstOrDefault();
                ViewBag.ss = details;
                return View();
            }
            else
            {
                return RedirectToAction("UserLogin","User");

            }

        }
        // GET: FlightBooking/Details/5

        public ActionResult ViewAllFlights()
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                return View(_context.FlightDetailsModels.ToList());
            }
            else
            {
                return RedirectToAction("UserLogin","User");

            }

        }

        
        public ActionResult BookingFlight(int id)
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                var detail = _context.FlightDetailsModels.Where(model => model.ResID == id).FirstOrDefault();
                ViewBag.planedetails = detail;
                return View("Booking");
            }
            else
            {
                return RedirectToAction("UserLogin","User");

            }


        }

        //public ActionResult Booking()
        //{
        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Booking([Bind("Bid,bCusName,bCusAddress,bCusEmail,bCusSeats,bCusPhoneNum,bCusCnic,ResId")] FlightBookingModel flightBookingModel)
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                if (ModelState.IsValid)
                {
                    _context.FlightBookingModels.Add(flightBookingModel);
                    _context.SaveChanges();
                    var detail = _context.FlightDetailsModels.Where(model => model.ResID == flightBookingModel.ResId).FirstOrDefault();
                    ViewBag.planedetails = detail;
                    ViewBag.m = "Record Saved";
                    return View();
                }
                return View(flightBookingModel);
            }
            else
            {
                return RedirectToAction("UserLogin","User");

            }

        }

        public ActionResult BookedFlights()
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                return View(_context.FlightBookingModels.ToList());
            }
            else
            {
                return RedirectToAction("UserLogin","User");

            }


        }



        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                var detail = _context.FlightDetailsModels.Where(model => model.ResID == id).FirstOrDefault();
                return View(detail);
            }
            else
            {
                return RedirectToAction("UserLogin","User");

            }

        }

        // GET: FlightBooking/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("UserLogin","User");

            }

        }

        // POST: FlightBooking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bid,bCusName,bCusAddress,bCusEmail,bCusSeats,bCusPhoneNum,bCusCnic,ResId")] FlightBookingModel flightBookingModel)
        {
            if (HttpContext.Session.GetString("_UserSession") != null)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(flightBookingModel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(flightBookingModel);
            }
            else
            {
                return RedirectToAction("UserLogin","User");

            }

        }

      
        
    }
}