using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
