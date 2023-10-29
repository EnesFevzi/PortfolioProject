using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.ViewComponents
{
    public class DashboardSkillViewComponent : ViewComponent
    {
        private readonly ISkillService _skillService;

        public DashboardSkillViewComponent(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Skills = await _skillService.GetAllSkillsNonDeletedAsync();
            return View(Skills);
        }
    }
}
