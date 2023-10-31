using FluentValidation;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using NToastNotify;
using PortfolioProject.Service.Models;
using PortfolioProject.Service.Service.Abstract;
using X.PagedList;
namespace PortfolioProject.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ISendMailService _sendMailService;
        private readonly IToastNotification _toastNotification;
        private readonly IValidator<MailRequest> _validator;

        public DashboardController(ISendMailService sendMailService, IToastNotification toastNotification, IValidator<MailRequest> validator)
        {
            _sendMailService = sendMailService;
            _toastNotification = toastNotification;
            _validator = validator;
        }

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult SendMail2()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(MailRequest mailRequest)
        {
            var result = await _validator.ValidateAsync(mailRequest);
            if (result.IsValid)
            {
                var ısMailSend = await _sendMailService.SendMail(mailRequest);
                if (ısMailSend)
                {
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false });
                }

            }
            else
            {
                _toastNotification.AddErrorToastMessage("Mail Gönderme işlemi tamamlanamadı", new ToastrOptions { Title = "İşlem Başarısız" });
            }
            return View();

        }

    }
}
