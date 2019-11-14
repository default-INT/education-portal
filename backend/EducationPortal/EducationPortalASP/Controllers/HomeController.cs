using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EducationPortalASP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using EducationPortalASP.ViewModel;
using EducationPortalASP.Data;

namespace EducationPortalASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<Account> userManager;
        private readonly ILogger<HomeController> logger;
        private readonly EducationPortalContext db;

        public HomeController(ILogger<HomeController> logger, UserManager<Account> userManager,
            EducationPortalContext db)
        {
            this.userManager = userManager;
            this.logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel()
            {
                User = userManager.Users.Where(u => u.UserName.Equals(User.Identity.Name))
                                  .FirstOrDefault(),
                Courses = db.Courses.Take(50).ToList()
            };
            return View(model);
        }

        public IActionResult Course(int? id)
        {
            HomeViewModel model = new HomeViewModel()
            {
                CourseItem = db.Courses.Where(c => c.Id == id).FirstOrDefault()
            };
            return View(model);
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
