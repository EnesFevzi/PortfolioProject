using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.ViewComponents
{
    public class DashboardAboutViewComponent : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public DashboardAboutViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var about = await _aboutService.GetAllAboutsNonDeletedAsync();
            return View(about);
        }
    }
}
