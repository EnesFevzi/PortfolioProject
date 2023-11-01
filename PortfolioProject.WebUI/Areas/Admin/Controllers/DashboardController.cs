using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IDashboardService _dashbordService;

        public DashboardController(IDashboardService dashbordService)
        {
            _dashbordService = dashbordService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> YearlyPortfolioCounts()
        {
            var count = await _dashbordService.GetYearlyPortfolioCounts();
            return Json(JsonConvert.SerializeObject(count));
        }
        [HttpGet]
        public async Task<IActionResult> TotalPortfolioCount()
        {
            var count = await _dashbordService.GetTotalPortfolioCount();
            return Json(count);
        }
        [HttpGet]
        public async Task<IActionResult> TotalExperienceCount()
        {
            var count = await _dashbordService.GetTotalExperienceCount();
            return Json(count);
        }

        [HttpGet]
        public async Task<IActionResult> TotalSkillCounts()
        {
            var count = await _dashbordService.GetTotalSkillCount();
            return Json(count);
        }

        [HttpGet]
        public async Task<IActionResult> TotalEducationCounts()
        {
            var count = await _dashbordService.GetTotalEducationCount();
            return Json(count);
        }
        [HttpGet]
        public async Task<IActionResult> TotalAboutCounts()
        {
            var count = await _dashbordService.GetTotalAboutCount();
            return Json(count);
        }
    }
}
