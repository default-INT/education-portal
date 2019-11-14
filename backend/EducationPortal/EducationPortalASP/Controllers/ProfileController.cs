using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationPortalASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EducationPortalASP.ViewModel;

namespace EducationPortalASP.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<Account> userManager;

        public ProfileController(UserManager<Account> userManager)
        {
            this.userManager = userManager;
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
                Skills = user.Skills
            };
            return View(model);
        }
    }
}