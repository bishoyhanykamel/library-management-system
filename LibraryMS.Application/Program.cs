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
		public static async Task Main(string[] args)
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
			services.AddIdentity<LibraryUser, IdentityRole>()
					.AddEntityFrameworkStores<LibraryDbContext>()
					.AddTokenProvider<DataProtectorTokenProvider<LibraryUser>>(TokenOptions.DefaultProvider);
			services.AddIdentity<ReaderUser, IdentityRole>()
					.AddEntityFrameworkStores<LibraryDbContext>()
					.AddTokenProvider<DataProtectorTokenProvider<ReaderUser>>(TokenOptions.DefaultProvider);
			#endregion

			var app = builder.Build();


			#region Data Migration
			// Migrate database
			using var appScope = app.Services.CreateScope();
			var appServices = appScope.ServiceProvider;
			var loggerFactory = appServices.GetRequiredService<ILoggerFactory>();
			try
			{
				var libraryDbContext = appServices.GetRequiredService<LibraryDbContext>();
				await libraryDbContext.Database.MigrateAsync();

				var roles = appServices.GetRequiredService<RoleManager<IdentityRole>>();
				await LibraryContextSeed.CreateRoles(roles, loggerFactory);
				// Seed user roles
			}
			catch (Exception ex)
			{
				var migrationLogger = loggerFactory.CreateLogger<Program>();
				migrationLogger.LogError(string.Empty, $"Error in migration - Program.cs - {ex.Message}");
			}
			#endregion


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