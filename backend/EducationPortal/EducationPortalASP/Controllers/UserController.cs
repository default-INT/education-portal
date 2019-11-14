using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationPortalASP.Models;
using EducationPortalASP.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EducationPortalASP.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<Account> userManager;
        private readonly SignInManager<Account> signInManager;

        public UserController(UserManager<Account> userManager, SignInManager<Account> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View((User) userManager.Users.Where(u => u.UserName.Equals(User.Identity.Name))
                                   .FirstOrDefault());
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var account = new User
                {
                    UserName = model.Login,
                    Email = model.Email,
                    FullName = model.FullName,
                    Sertificate = model.Sertificate,
                    Education = model.Education,
                    Skills = model.Skills
                    
                };
                var result = await userManager.CreateAsync(account, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(account, false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
  
        public async Task<IActionResult> LogOff()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}