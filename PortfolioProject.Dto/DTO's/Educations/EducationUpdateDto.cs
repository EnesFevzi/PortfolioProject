using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Dto.DTO_s.Educations
{
    public class EducationUpdateDto
    {
        public Guid EducationID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
