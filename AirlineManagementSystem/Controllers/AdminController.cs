using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineManagementSystem.Models;

namespace AirlineManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext dbContext;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminModel admin)
        {
            var model = dbContext.AdminModels.Where(adObj=>adObj.AdName == admin.AdName && adObj.Password == admin.Password).FirstOrDefault();
            if (model != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.m = "Wront userid or password";
            }
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}



