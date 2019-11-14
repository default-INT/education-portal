using System;
using System.Threading.Tasks;
using EducationPortalASP.Models;
using EducationPortalASP.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EducationPortalASP.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Account> userManager;
        private readonly SignInManager<Account> signInManager;

        public AccountController(UserManager<Account> userManager, SignInManager<Account> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                Account account = new Administrator { Email = model.Login, UserName = model.Login, FullName = model.FullName };
                var result = await this.userManager.CreateAsync(account, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(account, false);
                    return RedirectToAction("Home", "Index");
                }
                else
                {
                    foreach (var error in result.Errors){
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}