using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PortfolioProject.DataAccess.Context;
using PortfolioProject.DataAccess.Repositories.Abstract;
using PortfolioProject.DataAccess.Repositories.Concrete;
using PortfolioProject.DataAccess.UnıtOfWorks.Abstract;
using PortfolioProject.DataAccess.UnıtOfWorks.Concrete;

namespace PortfolioProject.DataAccess.Extensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
		{

			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

			services.AddScoped<IUnıtOfWork, UnitOfWork>();

			return services;


		}
	}
}
