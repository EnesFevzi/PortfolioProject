using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using PortfolioProject.Dto.DTO_s.Users;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Service.Abstract;
using PortfolioProject.Service.Service.Concrete;

namespace PortfolioProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
		

	
		public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;

        }
        [HttpGet]
        public IActionResult Login()
        {
			
			return View();
		}
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto, string token)
        {
			
			if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    if (userLoginDto.Password != null)
                    {
                        var result = await signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Experience", new { Area = "Admin" });
                        }
                        else
                        {
                            ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                            return View();
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                        return View();
                    }

                }
                else
                {
                    ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
		
		[Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }
		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> Error404()
		{
			return View();
		}

	}
}
