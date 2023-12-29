using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Repository.Data.DbContexts
{
	public class LibraryContextSeed
	{
		// Seed user roles
		public static async Task CreateRoles(RoleManager<IdentityRole> roleManager, ILoggerFactory loggerFactory)
		{
			string[] roleNames = { "User", "Librarian" };

			try
			{
				foreach (var roleName in roleNames)
				{
					bool roleExists = await roleManager.RoleExistsAsync(roleName);
					if (!roleExists)
						await roleManager.CreateAsync(new IdentityRole(roleName));
				}
			}
			catch (Exception ex)
			{
				var logger = loggerFactory.CreateLogger<LibraryContextSeed>();
				logger.LogError(string.Empty, $"Error in seeding roles - Msg: ${ex.Message}");
			}

		}
	}
}
