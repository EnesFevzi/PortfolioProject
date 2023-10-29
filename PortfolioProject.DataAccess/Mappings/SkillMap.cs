using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccess.Mappings
{
	public class SkillMap : IEntityTypeConfiguration<Skill>
	{
		public void Configure(EntityTypeBuilder<Skill> builder)
		{
			builder.HasData(new Skill
			{
				SkillID = Guid.Parse("359E96F1-42F4-42AC-8521-DF585BFF9086"),
				Title="C#",
				Value=90,
				CreatedDate = DateTime.Now,
				CreatedBy = "SuperAdmin",
				IsDeleted = false,
				UserID = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
			},
			new Skill
			{
				SkillID = Guid.Parse("62D9F2F3-9390-4CF8-A67A-92D98C71A2C6"),
				Title = "Microsoft SQL Server",
				Value = 90,
				CreatedDate = DateTime.Now,
				CreatedBy = "SuperAdmin",
				IsDeleted = false,
				UserID = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
			});
		}
	}
}
