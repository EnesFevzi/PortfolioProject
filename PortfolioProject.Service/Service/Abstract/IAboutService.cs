using PortfolioProject.Dto.DTO_s.Abouts;
using PortfolioProject.Dto.DTO_s.Educations;
using PortfolioProject.Dto.DTO_s.Portfolios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Abstract
{
    public interface IAboutService
    {
        Task<List<AboutDto>> GetAllAboutsNonDeletedAsync();
        Task<List<AboutDto>> GetAllAboutsDeletedAsync();
        Task<AboutDto> GetAboutNonDeletedAsync(Guid AboutID);
        Task CreateAboutAsync(AboutAddDto aboutAddDto);
        Task CreateAboutWithoutImageAsync(AboutAddDto aboutAddDto);
        Task<string> UpdateAboutAsync(AboutUpdateDto aboutUpdateDto);
        Task<string> SafeDeleteAboutAsync(Guid AboutID);
        Task<string> UndoDeleteAboutAsync(Guid AboutID);
    }
}
