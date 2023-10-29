using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioProject.Entity.Entities;

namespace PortfolioProject.DataAccess.Mappings
{
	public class ExperienceMap : IEntityTypeConfiguration<Experience>
	{
		public void Configure(EntityTypeBuilder<Experience> builder)
		{
			builder.HasData(new Experience
			{
				ExperienceID = Guid.Parse("C0CAE11A-F46B-4C89-B9CA-B80CE5152F22"),
				StartTime = new DateTime(2023,06,19),
				EndTime = new DateTime(2023,12,08),
				Name = "Bilge Adam Boost Yıldız Yazılımcı Yetiştirme Programı",
				Content = "Son teknolojiyle entegre edilmiş eğitim içeriği ve gerçek dünya uygulamaları ve\r\nsimülasyonlarını bir araya getiren, 8 ay süren yazılımcı yetiştirme programıdır.",
				CreatedDate = DateTime.Now,
				CreatedBy = "SuperAdmin",
				IsDeleted = false,
				UserID = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
			},
			new Experience
			{
				ExperienceID = Guid.Parse("112BD5A2-BE97-4648-A766-B78D3F22B800"),
				StartTime = new DateTime(2022, 06, 19),
				Name = "Eren Brulor",
				Content = "Mekatronik Mühendisi olarak çalıştığım Brülör Teknik Servis Şirketi",
				CreatedBy = "SuperAdmin",
				CreatedDate = DateTime.Now,
				IsDeleted = false,
				UserID = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
			});
		}
	}
}
