using AutoMapper;
using EducationProject.Service.Service.Abstract;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PortfolioProject.Dto.DTO_s.Educations;
using PortfolioProject.Entity.Entities;
using PortfolioProject.WebUI.Consts;
using PortfolioProject.WebUI.ResultMessages;

namespace PortfolioProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
	
	public class EducationController : Controller
    {
        private readonly IEducationService _educationService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;
        private readonly IValidator<Education> _validator;


        public EducationController(IEducationService educationService, IMapper mapper, IToastNotification toastNotification, IValidator<Education> validator)
        {
            _educationService = educationService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            _validator = validator;
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> Index()
        {
            var educations = await _educationService.GetAllEducationsNonDeletedAsync();
            return View(educations);
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> DeletedEducation()
        {
            var educations = await _educationService.GetAllEducationsDeletedAsync();
            return View(educations);
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> Add()
        {
            return View();
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		[HttpPost]
        public async Task<IActionResult> Add(EducationAddDto educationAddDto)
        {
            var map = _mapper.Map<Education>(educationAddDto);
            var result = await _validator.ValidateAsync(map);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else
            {
                await _educationService.CreateEducationAsync(educationAddDto);
                _toastNotification.AddSuccessToastMessage(Messages.Education.Add(educationAddDto.Name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Education", new { Area = "Admin" });

            }

            return View();

        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> Update(Guid educationId)
        {
            var experience = await _educationService.GetEducationWithUserNonDeletedAsync(educationId);
            var articleUpdateDto = _mapper.Map<EducationUpdateDto>(experience);
            return View(articleUpdateDto);
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		[HttpPost]
        public async Task<IActionResult> Update(EducationUpdateDto educationUpdateDto)
        {
            var map = _mapper.Map<Education>(educationUpdateDto);
            var result = await _validator.ValidateAsync(map);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else
            {
                var title = await _educationService.UpdateEducationAsync(educationUpdateDto);
                _toastNotification.AddSuccessToastMessage(Messages.Education.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Education", new { Area = "Admin" });
            }

            return View(educationUpdateDto);

        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> Delete(Guid educationId)
        {
            var title = await _educationService.SafeDeleteEducationAsync(educationId);
            _toastNotification.AddSuccessToastMessage(Messages.Education.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Education", new { Area = "Admin" });
        }
		[Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
		public async Task<IActionResult> UndoDelete(Guid educationId)
        {
            var title = await _educationService.UndoDeleteEducationAsync(educationId);
            _toastNotification.AddSuccessToastMessage(Messages.Education.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Education", new { Area = "Admin" });
        }
    }
}
