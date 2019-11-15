using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationPortalASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EducationPortalASP.ViewModel;
using EducationPortalASP.Data;

namespace EducationPortalASP.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<Account> userManager;
        private readonly EducationPortalContext db;

        public ProfileController(UserManager<Account> userManager, EducationPortalContext db)
        {
            this.userManager = userManager;
            this.db = db;
        }

        public IActionResult Index()
        {
            var user = (User)userManager.Users.Where(u => u.UserName.Equals(User.Identity.Name))
                                   .FirstOrDefault();
            ProfileViewModel model = new ProfileViewModel()
            {
                UserName = user.UserName,
                Sertificate = user.Sertificate,
                FullName = user.FullName,
                Education = user.Education,
                Skills = user.Skills,
                Courses = db.Courses.Where(c => c.User.UserName == user.UserName).Take(50)
            };
            return View(model);
        }
    }
}