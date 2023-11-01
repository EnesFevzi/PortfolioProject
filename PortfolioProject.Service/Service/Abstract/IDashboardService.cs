namespace PortfolioProject.Service.Service.Abstract
{
    public interface IDashboardService
    {
        Task<List<int>> GetYearlyPortfolioCounts();
        Task<int> GetTotalPortfolioCount();
        Task<int> GetTotalExperienceCount();
        Task<int> GetTotalSkillCount();
        Task<int> GetTotalEducationCount();
        Task<int> GetTotalAboutCount();
    }
}
