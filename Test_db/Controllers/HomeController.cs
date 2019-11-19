using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Test_db.Models;

namespace Test_db.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db;
        public HomeController(MobileContext context)
        {
            db = context;
        }
        /*public IActionResult Index()
        {
            return View(db.newss.ToList());
        }*/
        public IActionResult Index(int? inst)
        {
            return View();
           // return Json(await db.newss.Where(p => p.institution == inst).ToListAsync());
        }
        public async Task<IActionResult> getnews(int? inst)
        {
            return Json(await db.newss.Where(p => p.institution == inst).ToListAsync());
        }
        public async Task<IActionResult> getrem()
        {
            return Json(await db.reminds.ToListAsync());
        }
        public async Task<IActionResult> getqr(string? nam)
        {
            return Json(await db.qrs.Where(p => p.name == nam).ToListAsync());
        }
        /*private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
