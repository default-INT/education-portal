using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationPortalASP.Data;
using EducationPortalASP.Models;
using EducationPortalASP.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EducationPortalASP.Controllers
{
    public class CourseController : Controller
    {
        private readonly EducationPortalContext context;
        private SignInManager<Account> signInManager;

        public CourseController(EducationPortalContext context, SignInManager<Account> signInManager)
        {
            this.signInManager = signInManager;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var course = context.Courses.Add(new Course()
                {
                    Name = model.Name,
                    User = context.Users.Where(u => u.UserName.Equals(User.Identity.Name)).FirstOrDefault(),
                    Rating = new Random().Next(1, 100) / 10,
                    Bibliography = model.Bibliography,
                    HomeTask = model.HomeTask,
                    Descript = model.Description,
                    Dificult = Int32.Parse(model.Dificult),
                    Price = Double.Parse(model.Price)
                });
                context.SaveChanges();
                return RedirectToAction("Index", "Profile");
            }
            return View(model);
        }
    }
}