using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;
using X.PagedList;
namespace PortfolioProject.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public DashboardController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
