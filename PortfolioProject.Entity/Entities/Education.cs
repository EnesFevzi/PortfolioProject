using PortfolioProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Entities
{
	public class Education : EntityBase
	{
		public Guid EducationID { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Name { get; set; }
		public string Content { get; set; }
		public Guid UserID { get; set; }
		public AppUser User { get; set; }
	}
}
