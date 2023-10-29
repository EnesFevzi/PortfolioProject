using PortfolioProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Entity.Entities
{
    public class Skill : EntityBase
    {
        public Skill()
        {
            
        }
        public Skill(string title,int value,Guid userid, string createdBy)
        {
            Title = title;
            Value = value;
            CreatedBy = createdBy;
            UserID = userid;
        }
        public Guid SkillID { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }

        public Guid UserID { get; set; }
        public AppUser User { get; set; }
    }
}
