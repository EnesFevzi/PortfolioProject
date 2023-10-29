using PortfolioProject.Dto.DTO_s.Experiences;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Abstract
{
    public interface IExperienceService
    {
        Task<List<ExperienceDto>> GetAllExperiencesAsync();
        Task<List<ExperienceDto>> GetAllExperiencesNonDeletedAsync();
        Task<List<ExperienceDto>> GetAllExperiencesWithUserNonDeletedAsync();
        Task<List<ExperienceDto>> GetAllExperiencesDeletedAsync();
        Task<ExperienceDto> GetExperienceWithUserNonDeletedAsync(Guid experienceID);
        Task CreateExperienceAsync(ExperienceAddDto experienceAddDto);
        Task<string> UpdateExperienceAsync(ExperienceUpdateDto experienceUpdateDto);
        Task<string> SafeDeleteExperienceAsync(Guid experienceID);
        Task<string> UndoDeleteExperienceAsync(Guid experienceID);
    }
}
