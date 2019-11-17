using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test_db.Models;

namespace Test_db.Controllers
{
    public class NewsController : Controller
    {
        MobileContext db;
        public NewsController(MobileContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(int? inst)
        {
            return Json(await db.newss.Where(p => p.institution == inst).ToListAsync());
        }
    }
}
