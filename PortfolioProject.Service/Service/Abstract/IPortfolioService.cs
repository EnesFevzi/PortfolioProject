using PortfolioProject.Dto.DTO_s.Portfolios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Abstract
{
    public interface IPortfolioService
    {
        Task<List<PortfolioDto>> GetAllPortfoliosAsync();
        Task<List<PortfolioDto>> GetAllPortfoliosNonDeletedAsync();
        Task<List<PortfolioDto>> GetAllPortfoliosWithImageNonDeletedAsync();
        Task<List<PortfolioDto>> GetAllPortfoliosDeletedAsync();
        Task<List<PortfolioDto>> GetAllPortfoliosWithImageDeletedAsync();
        Task<PortfolioDto> GetPortfolioWithUserNonDeletedAsync(Guid PortfolioID);
        Task CreatePortfolioAsync(PortfolioAddDto PortfolioAddDto);
        Task<string> UpdatePortfolioAsync(PortfolioUpdateDto PortfolioUpdateDto);
        Task<string> SafeDeletePortfolioAsync(Guid PortfolioID);
        Task<string> UndoDeletePortfolioAsync(Guid PortfolioID);
    }
}
