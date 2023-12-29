using LibraryMS.Core.Entities;
using LibraryMS.Core.Interfaces.Repositories;
using LibraryMS.Repository.Data.DbContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryMS.Application
{
	public class Program
	{
		public static async void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var services = builder.Services;
			#region Application Services
			// Add services to the container.
			builder.Services.AddControllersWithViews();
			// Database connection
			services.AddDbContext<LibraryDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
			});

			// Adding Identity to Project
			services.AddIdentity<ApplicationUser, IdentityRole>()
					.AddEntityFrameworkStores<LibraryDbContext>()
					.AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider);
			#endregion

			var app = builder.Build();


			#region Application Pipelines
			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();
			app.UseAuthentication();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");
			#endregion

			app.Run();
		}
	}
}