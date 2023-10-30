using PortfolioProject.Dto.DTO_s.Educations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject.Service.Service.Abstract
{
    public interface IEducationService
    {
        Task<List<EducationDto>> GetAllEducationsAsync();
        Task<List<EducationDto>> GetAllEducationsNonDeletedAsync();
        Task<List<EducationDto>> GetAllEducationsDeletedAsync();
        Task<EducationDto> GetEducationWithUserNonDeletedAsync(Guid EducationID);
        Task CreateEducationAsync(EducationAddDto EducationAddDto);
        Task<string> UpdateEducationAsync(EducationUpdateDto EducationUpdateDto);
        Task<string> SafeDeleteEducationAsync(Guid EducationID);
        Task<string> UndoDeleteEducationAsync(Guid EducationID);
    }
}
