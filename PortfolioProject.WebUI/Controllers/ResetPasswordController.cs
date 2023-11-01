using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using NToastNotify;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Models;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.Controllers
{
	public class ResetPasswordController : Controller
	{
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManager;
		private readonly ISendMailService _sendMailService;
		private readonly IToastNotification _toastNotification;

		public ResetPasswordController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ISendMailService sendMailService, IToastNotification toastNotification)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
			_sendMailService = sendMailService;
			_toastNotification = toastNotification;
		}

		public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> ForgetPassword()
		{
			return View();
		}
		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> ForgetPassword(ForgetPassword forgetPassword)
		{
			return View();
		}
		[AllowAnonymous]
		[HttpGet]
		public IActionResult ResetPassword(Guid userid, string token)
		{
			TempData["userid"] = userid;
			TempData["token"] = token;
			return View();
		}
		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
		{
			var userid = TempData["userid"];
			var token = TempData["token"];
			if (userid == null || token == null)
			{
				//hata mesajı
			}
			var user = await userManager.FindByIdAsync(userid.ToString());
			var result = await userManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password);
			if (result.Succeeded)
			{
				return RedirectToAction("Login", "Auth");
			}
			return View();
		}
	}
}
