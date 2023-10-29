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
	internal class EducationMap : IEntityTypeConfiguration<Education>
	{
		public void Configure(EntityTypeBuilder<Education> builder)
		{
			builder.HasData(new Education
			{
				EducationID = Guid.Parse("D2FBACFA-415B-4C5A-B20C-EFE531C75D61"),
				StartTime = new DateTime(2023, 06, 19),
				EndTime = new DateTime(2023, 12, 08),
				Name = "Pamukkale Üniversitesi",
				Content = "Mekatronik Mühendisliği bölümünü 3.22 akademik ortalama ile bitirdim.",
				CreatedDate = DateTime.Now,
				CreatedBy = "SuperAdmin",
				IsDeleted = false,
				UserID = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
			},
			new Education
			{
				EducationID = Guid.Parse("36719172-EAF3-4963-AB41-D88AAC522F76"),
				StartTime = new DateTime(2023, 06, 19),
				EndTime = new DateTime(2023, 12, 08),
				Name = "Mehmet Rüştü Uzel Mesleki ve Teknik Anadolu Lisesi",
				Content = "Elektrik-Elektronik Teknolojisi Bölümünü Okul Birinciliği ile tamamladım.",
				CreatedDate = DateTime.Now,
				CreatedBy = "SuperAdmin",
				IsDeleted = false,
				UserID = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
			});
		}
	}
}
