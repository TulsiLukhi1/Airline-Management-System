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
        readonly AppDbContext _dbContext;

        public AdminController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            //if (session["admin"] != null)
            //{
            //    return RedirectToAction("Dashboard");
            //}
            //else
            //{
            //    return View();
            //}
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminModel admin)
        {
            var model = _dbContext.AdminModels.Where(adObj=>adObj.AdName == admin.AdName && adObj.Password == admin.Password).FirstOrDefault();
            if (model != null)
            {
                //Session["session"] = admin.AdName;
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.m = "Wrong userid or password";
            }
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}



