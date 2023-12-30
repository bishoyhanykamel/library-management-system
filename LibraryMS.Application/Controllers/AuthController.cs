using AutoMapper;
using LibraryMS.Application.ViewModels;
using LibraryMS.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMS.Application.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> userRoles;
		private readonly IMapper autoMapper;

		public AuthController(
            UserManager<ApplicationUser> _userManager,
            RoleManager<IdentityRole> _userRoles,
            IMapper _autoMapper)
        {
            userManager = _userManager;
            userRoles = _userRoles;
			autoMapper = _autoMapper;
		}

        #region Login
        public async Task<IActionResult> Login()
        {
            return View();
        }
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(AuthViewModel authViewModel)
		{
			return View();
		}
		#endregion

		#region Register
		public async Task<IActionResult> Register()
		{
			return View();
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AuthViewModel authViewModel)
        {
            return View();
        }
		#endregion

	}
}
