using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Dto.DTO_s.Abouts
{
    public class AboutDto
    {
        public Guid AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Linkedin { get; set; }
        public string GitHub { get; set; }
        public Image Image { get; set; }
        public bool IsDeleted { get; set; }

    }
}
