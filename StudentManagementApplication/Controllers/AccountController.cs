using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentManagementApplication.Data;
using StudentManagementApplication.Models;
using Microsoft.AspNetCore.Identity;

namespace StudentManagementApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // [HttpGet]
        // public IActionResult Login()
        // {
        //     return View();
        // }

        [HttpPost]
        // public async Task<IActionResult> Login(LoginViewModel model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

        //         if (result.Succeeded)
        //         {
        //             return RedirectToAction("Index", "Home");
        //         }

        //         if (result.IsLockedOut)
        //         {
        //             ModelState.AddModelError(string.Empty, "User account locked out.");
        //             return View(model);
        //         }
        //         else
        //         {
        //             ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //             return View(model);
        //         }
        //     }

        //     return View(model);
        // }

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
                var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }
    }
}

