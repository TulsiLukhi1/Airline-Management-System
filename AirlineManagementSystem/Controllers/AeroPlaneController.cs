using AirlineManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AirlineManagementSystem.Controllers
{
    public class AeroPlaneController : Controller

    {

        readonly AppDbContext _dbContext;
        public AeroPlaneController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: AeroPlaneController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                return View(_dbContext.AeroPlaneModels.ToList());
                
            }
            else
            {
                return RedirectToAction("AdminLogin","Admin");
            }
            
        }

        // GET: AeroPlaneController/Details/5
        public ActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                var detail = _dbContext.AeroPlaneModels.Where(model => model.PlaneId == id).FirstOrDefault();
                return View(detail);

            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
           
        }

        // GET: AeroPlaneController/Create
        public ActionResult Create()
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                return View();

            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            
        }

        // POST: AeroPlaneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(include: "PlaneId,APlaneName,SeatingCapacity,Price")] AeroPlaneModel aeroPlaneModel)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                if (ModelState.IsValid)
                {
                    _dbContext.AeroPlaneModels.Add(aeroPlaneModel);
                    _dbContext.SaveChanges();
                    ViewBag.m = "Record Saved";
                    return View();
                }
                return View(aeroPlaneModel);
            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

        }



        // GET: AeroPlaneController/Edit/5
        public ActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                var detail = _dbContext.AeroPlaneModels.Where(model => model.PlaneId == id).FirstOrDefault();
                return View(detail);
            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

           
        }

        // POST: AeroPlaneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind(include: "PlaneId,APlaneName,SeatingCapacity,Price")] AeroPlaneModel aeroPlaneModel)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                try
                {
                    var aeroplane = _dbContext.AeroPlaneModels.Where(model => model.PlaneId == id).FirstOrDefault();

                    _dbContext.AeroPlaneModels.Remove(aeroplane);
                    aeroPlaneModel.PlaneId = aeroplane.PlaneId;
                    _dbContext.AeroPlaneModels.Add(aeroPlaneModel);
                    _dbContext.SaveChanges();
                    ViewBag.m = "Information Updated";
                    return View();
                }
                catch
                {
                    return View(aeroPlaneModel);
                }
            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }

            
        }

        // GET: AeroPlaneController/Delete/5
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                var detail = _dbContext.AeroPlaneModels.Where(model => model.PlaneId == id).FirstOrDefault();
                return View(detail);

            }
            else
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
        }

        // POST: AeroPlaneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (HttpContext.Session.GetString("_AdminSession") != null)
            {
                try
                {
                    var aeroplane = _dbContext.AeroPlaneModels.Where(model => model.PlaneId == id).FirstOrDefault();
                    _dbContext.AeroPlaneModels.Remove(aeroplane);
                    _dbContext.SaveChanges();

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
