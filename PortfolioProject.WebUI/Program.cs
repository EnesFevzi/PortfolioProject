using Microsoft.AspNetCore.Identity;
using NToastNotify;
using PortfolioProject.DataAccess.Context;
using PortfolioProject.DataAccess.Extensions;
using PortfolioProject.Entity.Entities;
using PortfolioProject.Service.Describers;
using PortfolioProject.Service.Extensions;


namespace PortfolioProject.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddHttpClient();
            builder.Services.AddAuthorization();
            builder.Services.LoadDataLayerExtension(builder.Configuration);
			builder.Services.LoadServiceLayerExtension();
			builder.Services.AddSession();
            builder.Services.AddControllersWithViews().AddNToastNotifyToastr(new ToastrOptions()
            {
                PositionClass = ToastPositions.TopRight,
                TimeOut = 3000,
            })
             .AddRazorRuntimeCompilation();

            builder.Services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.User.RequireUniqueEmail = true;

            })
             .AddRoleManager<RoleManager<AppRole>>()
             .AddErrorDescriber<CustomIdentityErrorDescriber>()
             .AddEntityFrameworkStores<AppDbContext>()
            .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider);

            builder.Services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = new PathString("/Admin/Auth/Login");
                config.LogoutPath = new PathString("/Admin/Auth/Logout");
                config.Cookie = new CookieBuilder
                {
                    Name = "PortfolioProject",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest //Always 

                };
                config.SlidingExpiration = true;
                config.ExpireTimeSpan = TimeSpan.FromDays(7);
                config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");
               
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Admin/Auth/Error404");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
			app.UseStatusCodePagesWithReExecute("/Admin/Auth/Error404/");
			app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
			app.UseSession();
			app.UseAuthentication();
			app.UseAuthorization();

			//app.MapControllerRoute(
			//    name: "default",
			//    pattern: "{controller=Home}/{action=Index}/{id?}");

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapAreaControllerRoute(
				name: "Admin",
				areaName: "Admin",
				pattern: "{area:exists}/{controller=Home1}/{action=Index}/{id?}"
				);
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Dashboard}/{action=Index}/{id?}");

                //endpoints.MapDefaultControllerRoute();
            });

			app.Run();
        }
    }
}