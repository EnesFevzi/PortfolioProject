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
	public class AboutMap : IEntityTypeConfiguration<About>
	{
		public void Configure(EntityTypeBuilder<About> builder)
		{
			builder.HasData(new About
			{
				AboutID = Guid.Parse("3F3EEF04-EFAD-4615-B2E3-8FE2D8E5C1A7"),
				Title = "Junıor Software Developer",
				Description = "Üniversite eğitimim sırasında yazılım alanına olan ilgim, aldığım yazılım dersleriyle başladı. Bu süre zarfında, kendimi sürekli olarak geliştirmek ve yeni beceriler kazanmak için Türkiye'nin önde gelen teknoloji yarışmalarına katıldım ve bir dizi derece elde ettim. Mezuniyetimin ardından, Bilge Adam Akademi'nin Boost Yıldız Yazılımcı Yetiştirme programına katıldım.",
				Age = 25,
				Mail = "enesfevzicicekli@gmail.com",
				Address = "Çorlu/TEKİRDAĞ",
				Linkedin = "https://www.linkedin.com/in/enes-fevzi-cicekli",
				GitHub = "https://github.com/EnesFevzi",
				ImageID = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
				UserID= Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")

			});

			builder.HasOne(a => a.Image)
			.WithMany(x=>x.Abouts)
			.HasForeignKey(a => a.ImageID)
			.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
