using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Models;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.Service.Service.Concrete
{
	public class SendMailService : ISendMailService
    {
		private readonly UserManager<AppUser> _userManager;

		public SendMailService(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public Task<bool> SendMail(MailRequest mailRequest)
        {

			return Task.FromResult(true);
		}

		public async Task<bool> SendPasswordChange(string email, string scheme, string host)
		{
            return true;
		}
	}
}
