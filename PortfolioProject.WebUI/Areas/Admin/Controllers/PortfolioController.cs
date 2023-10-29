using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;
        private readonly IValidator<Portfolio> _validator;

        public PortfolioController(IPortfolioService portfolioService, IMapper mapper, IToastNotification toastNotification, IValidator<Portfolio> validator)
        {
            _portfolioService = portfolioService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            _validator = validator;
        }

        public IActionResult Index()
        {
            var portfolios = _portfolioService.GetAllPortfoliosDeletedAsync();
            return View(portfolios);
        }
    }
}
