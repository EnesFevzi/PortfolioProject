using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortfolioProject.Entity.Entities;

namespace PortfolioProject.DataAccess.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
	{
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.HasData(new Image
			{
				ImageID = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
				FileName = "project-images/defaultPortfolio.jpg",
				FileType = "image/jpeg",
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false
			},
			new Image
			{
				ImageID = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
				FileName = "images/vstest",
				FileType = "png",
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false
			});
		}
	}
}
