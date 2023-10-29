using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Entities
{
	public class Message
	{
		public Guid MessageID { get; set; }
		public string Name { get; set; }
		public string Mail { get; set; }
		public string Content { get; set; }
		public DateTime Date { get; set; }
		public bool IsRead { get; set; } = false;
	}
}
