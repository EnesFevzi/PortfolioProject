using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Concrete
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnıtOfWork _unıtOfWork;

        public DashboardService(IUnıtOfWork unıtOfWork)
        {
            _unıtOfWork = unıtOfWork;
        }

        public async Task<int> GetTotalPortfolioCount()
        {
            var portfolioCount = await _unıtOfWork.GetRepository<Portfolio>().CountAsync(x => !x.IsDeleted);
            return portfolioCount;
        }
        public async Task<int> GetTotalExperienceCount()
        {
            var categoryCount = await _unıtOfWork.GetRepository<Experience>().CountAsync(x => !x.IsDeleted);
            return categoryCount;
        }

        public async Task<int> GetTotalSkillCount()
        {
            var userCount = await _unıtOfWork.GetRepository<Skill>().CountAsync(x => !x.IsDeleted);
            return userCount;
        }
        public async Task<int> GetTotalEducationCount()
        {
            var userCount = await _unıtOfWork.GetRepository<Education>().CountAsync(x => !x.IsDeleted);
            return userCount;
        }

        public async Task<List<int>> GetYearlyPortfolioCounts()
        {
            var articles = await _unıtOfWork.GetRepository<Portfolio>().GetAllAsync(x => !x.IsDeleted);

            var startDate = DateTime.Now.Date;
            startDate = new DateTime(startDate.Year, 1, 1);

            List<int> datas = new();

            for (int i = 1; i <= 12; i++)
            {
                var startedDate = new DateTime(startDate.Year, i, 1);
                var endedDate = startedDate.AddMonths(1);
                var data = articles.Where(x => x.CreatedDate >= startedDate && x.CreatedDate < endedDate).Count();
                datas.Add(data);
            }

            return datas;

        }

        public  async Task<int> GetTotalAboutCount()
        {
            var userCount = await _unıtOfWork.GetRepository<About>().CountAsync(x => !x.IsDeleted);
            return userCount;
        }
    }
}
