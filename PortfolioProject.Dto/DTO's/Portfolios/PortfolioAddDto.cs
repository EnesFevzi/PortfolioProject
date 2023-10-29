using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Dto.DTO_s.Portfolios
{
    public class PortfolioAddDto
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string ProjectURL { get; set; }

        public IFormFile? Photo { get; set; }
    }
}
