using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;
using X.PagedList;

namespace PortfolioProject.WebUI.ViewComponents
{
    public class DashboardPortfolioViewComponent : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public DashboardPortfolioViewComponent(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var experiences = await _portfolioService.GetAllPortfoliosWithImageNonDeletedAsync();
            var last6Experiences = experiences.OrderByDescending(e => e.CreateDate).Take(6).ToList();
            return View(last6Experiences);
        }
    }
}
