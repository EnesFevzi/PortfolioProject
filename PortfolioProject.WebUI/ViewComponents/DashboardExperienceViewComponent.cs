using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.ViewComponents
{
    public class DashboardExperienceViewComponent : ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public DashboardExperienceViewComponent(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var experiences = await _experienceService.GetAllExperiencesNonDeletedAsync();
            return View(experiences);
        }
    }
}
