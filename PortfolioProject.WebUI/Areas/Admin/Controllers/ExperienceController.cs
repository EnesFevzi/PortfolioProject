using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PortfolioProject.Dto.DTO_s.Experiences;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Service.Abstract;
using PortfolioProject.WebUI.Consts;
using PortfolioProject.WebUI.ResultMessages;

namespace PortfolioProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
	public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;
        private readonly IValidator<Experience> _validator;


        public ExperienceController(IExperienceService experienceService , IMapper mapper, IToastNotification toastNotification, IValidator<Experience> validator)
        {
            _experienceService = experienceService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            _validator = validator;
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task< IActionResult> Index()
        {
            var articles = await _experienceService.GetAllExperiencesWithUserNonDeletedAsync();
            return View(articles);
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> DeletedExperience()
		{
			var articles = await _experienceService.GetAllExperiencesDeletedAsync();
			return View(articles);
		}
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> Add()
        {
            return View();
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		[HttpPost]
        public async Task<IActionResult> Add(ExperienceAddDto experienceAddDto)
        {
            var map = _mapper.Map<Experience>(experienceAddDto);
            var result = await _validator.ValidateAsync(map);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else
            {
                await _experienceService.CreateExperienceAsync(experienceAddDto);
                _toastNotification.AddSuccessToastMessage(Messages.Experience.Add(experienceAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Experience", new { Area = "Admin" });

            }
            
            return View();

        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> Update(Guid experienceId)
        {
            var experience = await _experienceService.GetExperienceWithUserNonDeletedAsync(experienceId);
            var articleUpdateDto = _mapper.Map<ExperienceUpdateDto>(experience);
            return View(articleUpdateDto);
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		[HttpPost]
        public async Task<IActionResult> Update(ExperienceUpdateDto experienceUpdateDto)
        {
            var map = _mapper.Map<Experience>(experienceUpdateDto);
            var result = await _validator.ValidateAsync(map);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else
            {
                var title = await _experienceService.UpdateExperienceAsync(experienceUpdateDto);
                _toastNotification.AddSuccessToastMessage(Messages.Experience.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Experience", new { Area = "Admin" });
            }
    
            return View(experienceUpdateDto);
          
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> Delete(Guid experienceId)
        {
            var title = await _experienceService.SafeDeleteExperienceAsync(experienceId);
            _toastNotification.AddSuccessToastMessage(Messages.Experience.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Experience", new { Area = "Admin" });
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> UndoDelete(Guid experienceId)
        {
            var title = await _experienceService.UndoDeleteExperienceAsync(experienceId);
            _toastNotification.AddSuccessToastMessage(Messages.Experience.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Experience", new { Area = "Admin" });
        }
    }
}
