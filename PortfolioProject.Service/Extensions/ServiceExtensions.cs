using EducationProject.Service.Service.Abstract;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PortfolioProject.Service.FluentValidations;
using PortfolioProject.Service.Helpers.Images.Abstract;
using PortfolioProject.Service.Helpers.Images.Concrete;
using PortfolioProject.Service.Service.Abstract;
using PortfolioProject.Service.Service.Concrete;
using System.Globalization;
using System.Reflection;

namespace PortfolioProject.Service.Extensions
{
	public static class ServiceExtensions
	{
		public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
		{
			var assembly = Assembly.GetExecutingAssembly();
			services.AddScoped<IImageHelper, ImageHelper>();
			services.AddScoped<IExperienceService, ExperienceService>();
			services.AddScoped<ISkillService, SkillService>();
			services.AddScoped<IPortfolioService, PortfolioService>();
			services.AddScoped<IEducationService, EducationService>();
			services.AddScoped<IAboutService, AboutService>();
			services.AddScoped<ISendMailService, SendMailService>();
			services.AddScoped<IDashboardService, DashboardService>();
			services.AddScoped<IUserService, UserService>();
		
			services.AddAutoMapper(assembly);

			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			services.AddControllersWithViews()
				.AddFluentValidation(opt =>
				{
					opt.RegisterValidatorsFromAssemblyContaining<SkillValidator>();
					opt.DisableDataAnnotationsValidation = true;
					opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
				});

			return services;


		}
	}
}
