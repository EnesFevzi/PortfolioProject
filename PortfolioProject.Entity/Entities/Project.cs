using PortfolioProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Entities
{
    public class Project : EntityBase
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string ProjectURL { get; set; }
		public Guid? ImageID { get; set; }
		public Image Image { get; set; }

	}
}
