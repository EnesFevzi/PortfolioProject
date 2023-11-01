using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Service.Service.Abstract;

namespace PortfolioProject.WebUI.Areas.Admin.ViewComponents
{
    public class DashboardHeaderViewComponent : ViewComponent
    {

        private readonly IUserService userService;


        public DashboardHeaderViewComponent(IUserService userService)
        {

            this.userService = userService;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userService.GetUserProfileAsyncWitRoleAsync();
            return View(user);
        }
    }
}
