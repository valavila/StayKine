using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MillionMealsGoldLeaf.Data;
using MillionMealsGoldLeaf.Models;

namespace MillionMealsGoldLeaf.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmailContext DBcontext;

        public HomeController(ILogger<HomeController> logger, EmailContext context)
        {
            _logger = logger;
            DBcontext = context;
            
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Email model)
        {

            if (ModelState.IsValid)
            {
                
                Email newEmail = new Email
                {
                    email = model.email,
                    isSubscribed = true
                };

                DBcontext.Add(newEmail);
                await DBcontext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
