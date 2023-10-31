using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.ViewComponents
{
    public class DashboardContactUserInformatıonViewComponent : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public DashboardContactUserInformatıonViewComponent(IAboutService aboutService)
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
