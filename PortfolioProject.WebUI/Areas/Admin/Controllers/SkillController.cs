using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using PortfolioProject.Dto.DTO_s.Skills;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Service.Abstract;
using PortfolioProject.WebUI.ResultMessages;

namespace PortfolioProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SkillController : Controller
    {

        private readonly ISkillService _skillService;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;
        private readonly IValidator<Skill> _validator;

        public SkillController(ISkillService SkillService, IMapper mapper, IToastNotification toastNotification, IValidator<Skill> validator)
        {
            _skillService = SkillService;
            _mapper = mapper;
            _toastNotification = toastNotification;
            _validator = validator;
        }

        public async Task<IActionResult> Index()
        {
            var skills = await _skillService.GetAllSkillsWithUserNonDeletedAsync();
            return View(skills);
        }

        public async Task<IActionResult> DeletedSkill()
        {
            var skills = await _skillService.GetAllSkillsDeletedAsync();
            return View(skills);
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(SkillAddDto SkillAddDto)
        {
            var map = _mapper.Map<Skill>(SkillAddDto);
            var result = await _validator.ValidateAsync(map);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else
            {
                await _skillService.CreateSkillAsync(SkillAddDto);
                _toastNotification.AddSuccessToastMessage(Messages.Skill.Add(SkillAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Skill", new { Area = "Admin" });

            }

            return View();

        }

        public async Task<IActionResult> Update(Guid SkillId)
        {
            var Skill = await _skillService.GetSkillWithUserNonDeletedAsync(SkillId);
            var articleUpdateDto = _mapper.Map<SkillUpdateDto>(Skill);
            return View(articleUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SkillUpdateDto SkillUpdateDto)
        {
            var map = _mapper.Map<Skill>(SkillUpdateDto);
            var result = await _validator.ValidateAsync(map);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);

            }
            else
            {
                var title = await _skillService.UpdateSkillAsync(SkillUpdateDto);
                _toastNotification.AddSuccessToastMessage(Messages.Skill.Update(title), new ToastrOptions() { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Skill", new { Area = "Admin" });
            }

            return View(SkillUpdateDto);

        }
        public async Task<IActionResult> Delete(Guid SkillId)
        {
            var title = await _skillService.SafeDeleteSkillAsync(SkillId);
            _toastNotification.AddSuccessToastMessage(Messages.Skill.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Skill", new { Area = "Admin" });
        }

        public async Task<IActionResult> UndoDelete(Guid SkillId)
        {
            var title = await _skillService.UndoDeleteSkillAsync(SkillId);
            _toastNotification.AddSuccessToastMessage(Messages.Skill.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });
            return RedirectToAction("Index", "Skill", new { Area = "Admin" });
        }
    }
}
