using EducationProject.Service.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.ViewComponents
{
    public class DashboardEducationViewComponent : ViewComponent
    {
        private readonly IEducationService _educationService;

        public DashboardEducationViewComponent(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var experiences = await _educationService.GetAllEducationsNonDeletedAsync();
            return View(experiences);
        }
    }
}
