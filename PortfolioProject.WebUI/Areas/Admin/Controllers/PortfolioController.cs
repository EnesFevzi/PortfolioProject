using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PortfolioProject.Dto.DTO_s.Portfolios;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Service.Abstract;
using PortfolioProject.Service.Service.Concrete;
using PortfolioProject.WebUI.ResultMessages;

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
        private readonly IValidator<PortfolioAddDto> _addvalidator;

        public PortfolioController(IPortfolioService portfolioService, IMapper mapper, IToastNotification toastNotification, IValidator<Portfolio> validator, IValidator<PortfolioAddDto> addvalidator)
        {
            _portfolioService = portfolioService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            _validator = validator;
            _addvalidator = addvalidator;
        }

        public async Task<IActionResult> Index()
        {
            var portfolios = await _portfolioService.GetAllPortfoliosNonDeletedAsync();
            return View(portfolios);
        }
        public async Task<IActionResult> DeletedPortfolio()
        {
            var articles = await _portfolioService.GetAllPortfoliosDeletedAsync();
            return View(articles);
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PortfolioAddDto portfolioAddDto)
        {
            var map = _mapper.Map<Portfolio>(portfolioAddDto);
            var result = await _validator.ValidateAsync(map);
            var result2 = await _addvalidator.ValidateAsync(portfolioAddDto);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else if (portfolioAddDto.Photo == null)
            {
                //result.AddToModelState(this.ModelState);
                await _portfolioService.CreatePortfoliWithoutImageAsync(portfolioAddDto);
                _toastNotification.AddSuccessToastMessage(Messages.Portfolio.Add(portfolioAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });

            }
            else
            {
                await _portfolioService.CreatePortfolioAsync(portfolioAddDto);
                _toastNotification.AddSuccessToastMessage(Messages.Portfolio.Add(portfolioAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });
            }
            return View();
        }

        public async Task<IActionResult> Update(Guid portfolioId)
        {
            var portfolio = await _portfolioService.GetPortfolioWithUserNonDeletedAsync(portfolioId);
            var articleUpdateDto = _mapper.Map<PortfolioUpdateDto>(portfolio);
            return View(articleUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(PortfolioUpdateDto portfolioUpdateDto)
        {
            var map = _mapper.Map<Portfolio>(portfolioUpdateDto);
            var result = await _validator.ValidateAsync(map);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else
            {
                var title = await _portfolioService.UpdatePortfolioAsync(portfolioUpdateDto);
                _toastNotification.AddSuccessToastMessage(Messages.Portfolio.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });
            }
            return View(portfolioUpdateDto);

        }
        public async Task<IActionResult> Delete(Guid portfolioId)
        {
            var title = await _portfolioService.SafeDeletePortfolioAsync(portfolioId);
            _toastNotification.AddSuccessToastMessage(Messages.Portfolio.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });
        }

        public async Task<IActionResult> UndoDelete(Guid portfolioId)
        {
            var title = await _portfolioService.UndoDeletePortfolioAsync(portfolioId);
            _toastNotification.AddSuccessToastMessage(Messages.Portfolio.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Portfolio", new { Area = "Admin" });
        }
    }
}
