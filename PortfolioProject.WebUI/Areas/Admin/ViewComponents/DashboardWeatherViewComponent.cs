using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.Areas.Admin.ViewComponents
{
    public class DashboardWeatherViewComponent : ViewComponent
    {
        private readonly IUserService _userService;

        public DashboardWeatherViewComponent(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var weatherInfo = await _userService.GetWeatherInfo();
            ViewBag.HavaDurumu = weatherInfo.Condition;
            ViewBag.Sicaklik = weatherInfo.Temperature;
            return View(weatherInfo);
        }
    }
}
