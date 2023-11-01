using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PortfolioProject.Dto.DTO_s.Abouts;
using PortfolioProject.Dto.DTO_s.Portfolios;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Service.Abstract;
using PortfolioProject.WebUI.Consts;
using PortfolioProject.WebUI.ResultMessages;

namespace PortfolioProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
	public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;
        private readonly IValidator<About> _validator;


        public AboutController(IAboutService aboutService, IMapper mapper, IToastNotification toastNotification, IValidator<About> validator )
        {
            _aboutService = aboutService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            _validator = validator;
          
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutService.GetAllAboutsNonDeletedAsync();
            return View(abouts);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedAbout()
        {
            var abouts = await _aboutService.GetAllAboutsDeletedAsync();
            return View(abouts);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        [HttpPost]
        public async Task<IActionResult> Add(AboutAddDto aboutAddDto)
        {
            var map = _mapper.Map<About>(aboutAddDto);
            var result = await _validator.ValidateAsync(map);
         
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else if (aboutAddDto.Photo == null)
            {
                //result.AddToModelState(this.ModelState);
                await _aboutService.CreateAboutWithoutImageAsync(aboutAddDto);
                _toastNotification.AddSuccessToastMessage(Messages.About.Add(aboutAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "About", new { Area = "Admin" });

            }
            else
            {
                await _aboutService.CreateAboutAsync(aboutAddDto);
                _toastNotification.AddSuccessToastMessage(Messages.About.Add(aboutAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "About", new { Area = "Admin" });
            }
            return View();
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Update(Guid aboutId)
        {
            var portfolio = await _aboutService.GetAboutNonDeletedAsync(aboutId);
            var articleUpdateDto = _mapper.Map<AboutUpdateDto>(portfolio);
            return View(articleUpdateDto);
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        [HttpPost]
        public async Task<IActionResult> Update(AboutUpdateDto aboutUpdateDto)
        {
            var map = _mapper.Map<About>(aboutUpdateDto);
            var result = await _validator.ValidateAsync(map);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else
            {
                var title = await _aboutService.UpdateAboutAsync(aboutUpdateDto);
                _toastNotification.AddSuccessToastMessage(Messages.About.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "About", new { Area = "Admin" });
            }
            return View(aboutUpdateDto);

        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> Delete(Guid aboutId)
        {
            var title = await _aboutService.SafeDeleteAboutAsync(aboutId);
            _toastNotification.AddSuccessToastMessage(Messages.About.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "About", new { Area = "Admin" });
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}")]
        public async Task<IActionResult> UndoDelete(Guid aboutId)
        {
            var title = await _aboutService.UndoDeleteAboutAsync(aboutId);
            _toastNotification.AddSuccessToastMessage(Messages.About.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "About", new { Area = "Admin" });
        }
    }
}
