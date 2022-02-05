using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moon_task.DAL;
using Moon_task.Models;
using Moon_task.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Moon_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            HomeViewModel moon = new HomeViewModel
            {
                jumborton = _db.jumborton.FirstOrDefault(),
                counter = _db.counters.ToList(),
                whoWeAre = _db.whoWeAres.ToList(),
                features = _db.features.ToList(),
                socialMedias = _db.socialMedias.ToList(),
                news = _db.news.ToList(),
                categories = _db.categories.ToList(),
                portfolios = _db.portfolios.ToList(),
                pricings = _db.pricing.ToList(),
                clients = _db.clients.ToList(),
            };
            return View(moon);
        }
    }
}
